using UnityEngine;

public class PlayerMovement : PlayerController
{
    private Vector2 movement;

    [Range(1f, 8f)]
    [SerializeField] private int speed;

    private void FixedUpdate()
    {
        OnMovement();
    }

    private void OnMovement()
    {
        movement = inputManagerInstance.movement;

        if (movement.sqrMagnitude > 0 && inputManagerInstance.isRunning < 0.5f)
        {
            speed = 3;
            playerAnimationsInstance.SwitchAnimation(PlayerAnimations.Animations.WALK);
        }
        else if (movement.sqrMagnitude > 0 && inputManagerInstance.isRunning > 0.5f)
        {
            speed = 7;
            playerAnimationsInstance.SwitchAnimation(PlayerAnimations.Animations.RUN);
        }
        else
            playerAnimationsInstance.SwitchAnimation(PlayerAnimations.Animations.IDLE);

        transform.position += new Vector3(movement.x, movement.y, 0) * Time.fixedDeltaTime * speed;
    }
}