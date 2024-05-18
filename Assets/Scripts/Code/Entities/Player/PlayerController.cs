using UnityEngine;

public class PlayerController : MonoBehaviour
{
    protected PlayerInputManager inputManagerInstance;

    private void Start()
    {
        inputManagerInstance = new PlayerInputManager();
    }
}
