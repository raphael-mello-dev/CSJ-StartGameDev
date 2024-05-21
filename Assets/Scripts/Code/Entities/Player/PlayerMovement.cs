using UnityEngine;

public class PlayerMovement : PlayerController
{
    private Vector2 movement;

    [Range(1f, 4f)]
    [SerializeField] private int speed;

    private void FixedUpdate()
    {
        OnMovement();
    }

    private void OnMovement()
    {
        movement = inputManagerInstance.movement;
        transform.position += new Vector3(movement.x, movement.y, 0) * Time.fixedDeltaTime * speed;

        if (movement.sqrMagnitude > 0)
            playerAnimationsInstance.SwitchAnimation(PlayerAnimations.Animations.WALK);
        else
            playerAnimationsInstance.SwitchAnimation(PlayerAnimations.Animations.IDLE);
    }
}