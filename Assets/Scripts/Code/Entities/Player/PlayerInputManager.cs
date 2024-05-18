using UnityEngine;

public class PlayerInputManager
{
    private Controls Controls;

    public Vector2 movement => Controls.Gameplay.Movement.ReadValue<Vector2>();

    public PlayerInputManager()
    {
        Controls = new Controls();
        Controls.Gameplay.Enable();
    }
}
