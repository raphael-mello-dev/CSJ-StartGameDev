using UnityEngine;

public class PlayerAnimations
{
    public enum Animations
    {
        IDLE = 0,
        WALK = 1,
        RUN = 2,
        DOGDE = 3
    }

    private Animator playerAnimator;

    public PlayerAnimations(Animator reference)
    {
        playerAnimator = reference;
    }

    public void SwitchAnimation(Animations currentAnimation)
    {
        playerAnimator.SetInteger("Transition", (int) currentAnimation);
    }
}