using UnityEngine;

[RequireComponent (typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerRotation))]

public class PlayerController : MonoBehaviour
{
    protected PlayerInputManager inputManagerInstance;

    private void Start()
    {
        inputManagerInstance = new PlayerInputManager();
    }
}