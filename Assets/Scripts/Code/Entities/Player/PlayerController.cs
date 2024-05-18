using UnityEngine;

[RequireComponent (typeof(PlayerMovement))]

public class PlayerController : MonoBehaviour
{
    protected PlayerInputManager inputManagerInstance;

    protected Rigidbody2D rb;

    private void Start()
    {
        inputManagerInstance = new PlayerInputManager();
        rb = GetComponent<Rigidbody2D>();
    }
}