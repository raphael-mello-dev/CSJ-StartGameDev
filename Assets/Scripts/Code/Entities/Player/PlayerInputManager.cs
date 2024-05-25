using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager
{
    private Controls Controls;

    public Vector2 movement => Controls.Gameplay.Movement.ReadValue<Vector2>();
    public float isRunning => Controls.Gameplay.Running.ReadValue<float>();

    public event Action OnDodge;

    public PlayerInputManager()
    {
        Controls = new Controls();
        Controls.Gameplay.Enable();

        Controls.Gameplay.Dodge.performed += OnDodgePerformed;
    }

    private void OnDodgePerformed(InputAction.CallbackContext context)
    {
        OnDodge?.Invoke();
    }
}