using System.Collections;
using UnityEngine;

public class PlayerDodge : PlayerController
{
    [SerializeField] private bool isDodging;

    public bool IsDodging
    {
        get { return isDodging; }
        private set { isDodging = value; }
    }

    private void OnEnable()
    {
        inputManagerInstance.OnDodge += OnDodge;
    }

    private void OnDisable()
    {
        inputManagerInstance.OnDodge -= OnDodge;
    }

    private void OnDodge()
    {
        IsDodging = true;
        StartCoroutine("OnDodgeEnd");
    }

    private IEnumerator OnDodgeEnd()
    {
        yield return new WaitForSecondsRealtime(0.1f);
        IsDodging = false;
    }
}