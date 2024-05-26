using UnityEngine;

public class PlayerAnimations
{
    public enum MoveAnimations
    {
        IDLE = 0,
        WALK = 1,
        RUN = 2,
        DODGE = 3
    }

    private Animator playerAnimator;

    public PlayerAnimations(Animator reference)
    {
        playerAnimator = reference;
    }

    public void SwitchMoveAnimations(MoveAnimations currentAnimation)
    {
        playerAnimator.SetInteger("Transition", (int) currentAnimation);
    }
}