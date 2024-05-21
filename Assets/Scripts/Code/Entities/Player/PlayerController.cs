using UnityEngine;

[RequireComponent (typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerRotation))]

public class PlayerController : MonoBehaviour
{
    protected PlayerInputManager inputManagerInstance;
    protected PlayerAnimations playerAnimationsInstance;

    private void Awake()
    {
        inputManagerInstance = new PlayerInputManager();
        playerAnimationsInstance = new PlayerAnimations(GetComponent<Animator>());
    }
}