using UnityEngine;

public class PlayerMovement : PlayerController
{
    private Vector2 movement;

    [Range(1f, 4f)]
    [SerializeField] private int speed;

    private void FixedUpdate()
    {
        movement = inputManagerInstance.movement;
        transform.Translate(new Vector3(movement.x, movement.y, 0) * Time.fixedDeltaTime * speed);
    }
}
