using UnityEngine;

[RequireComponent (typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerRotation))]
[RequireComponent(typeof(PlayerDodge))]

public class PlayerController : MonoBehaviour
{
    protected PlayerInputManager inputManagerInstance;
    protected PlayerAnimations playerAnimationsInstance;

    protected Rigidbody2D playerRigBody;

    private void Awake()
    {
        inputManagerInstance = new PlayerInputManager();
        playerAnimationsInstance = new PlayerAnimations(GetComponent<Animator>());

        playerRigBody = GetComponent<Rigidbody2D>();
    }
}