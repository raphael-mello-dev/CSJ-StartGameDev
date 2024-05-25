using System.Collections;
using UnityEngine;

public class PlayerDodge : PlayerController
{
    private Vector2 dodgeX;
    private Vector2 dodgeY;

    private void OnEnable()
    {
        inputManagerInstance.OnDodge += playerAnimationsInstance.PlayDodgeAnimation;
        inputManagerInstance.OnDodge += OnDodge;
    }

    private void OnDisable()
    {
        inputManagerInstance.OnDodge -= playerAnimationsInstance.PlayDodgeAnimation;
        inputManagerInstance.OnDodge -= OnDodge;
    }

    /*private void Update()
    {
        dodgeX = new Vector2(inputManagerInstance.movement.x * 10, 0);
        dodgeY = new Vector2(0, inputManagerInstance.movement.y * 10);
    }*/

    private void OnDodge()
    {
        if (inputManagerInstance.movement.x > 0)
        {
            playerRigBody.AddForce(Vector2.right * 7.5f, ForceMode2D.Impulse);
            StartCoroutine("DodgeEnd");
        }
        else if (inputManagerInstance.movement.x < 0)
        {
            playerRigBody.AddForce(Vector2.left * 7.5f, ForceMode2D.Impulse);
            StartCoroutine("DodgeEnd");
        }
        else if (inputManagerInstance.movement.y > 0)
        {
            playerRigBody.AddForce(Vector2.up * 7.5f, ForceMode2D.Impulse);
            StartCoroutine("DodgeEnd");
        }
        else if (inputManagerInstance.movement.y < 0)
        {
            playerRigBody.AddForce(Vector2.down * 7.5f, ForceMode2D.Impulse);
            StartCoroutine("DodgeEnd");
        }
    }

    private IEnumerator DodgeEnd()
    {
        yield return new WaitForSecondsRealtime(0.07f);
        playerRigBody.velocity = Vector2.zero;
    }
}