using UnityEngine;

public class PlayerRotation : PlayerController
{
    void FixedUpdate()
    {
        OnRotate();
    }

    private void OnRotate()
    {
        if (inputManagerInstance.movement.x > 0)
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        else if (inputManagerInstance.movement.x < 0)
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    }
}