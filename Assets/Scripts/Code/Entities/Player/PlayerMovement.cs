using UnityEngine;

public class PlayerMovement : PlayerController
{
    private Vector2 movement;

    [Range(1f, 10f)]
    [SerializeField] private int speed;

    private PlayerDodge playerDodge;

    private void Start()
    {
        playerDodge = GetComponent<PlayerDodge>();
    }

    private void FixedUpdate()
    {
        OnMovement();
    }

    private void OnMovement()
    {
        movement = inputManagerInstance.movement;
        

        if (movement.sqrMagnitude == 0)
        {
            playerAnimationsInstance.SwitchMoveAnimations(PlayerAnimations.MoveAnimations.IDLE);
        }
        else if (movement.sqrMagnitude > 0 && playerDodge.IsDodging)
        {
            speed = 8;
            playerAnimationsInstance.SwitchMoveAnimations(PlayerAnimations.MoveAnimations.DODGE);
        }
        else if (movement.sqrMagnitude > 0 && inputManagerInstance.isRunning > 0.5f)
        {
            speed = 7;
            playerAnimationsInstance.SwitchMoveAnimations(PlayerAnimations.MoveAnimations.RUN);
        }
        else
        {
            speed = 3;
            playerAnimationsInstance.SwitchMoveAnimations(PlayerAnimations.MoveAnimations.WALK);
        }

        transform.position += new Vector3(movement.x, movement.y, 0) * Time.fixedDeltaTime * speed;
    }
}