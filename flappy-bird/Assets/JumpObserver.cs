using UnityEngine;

public class JumpObserver : MonoBehaviour
{
    public GravityController GravityController;

    private bool firstJumpObserved = false;

    public void OnNext()
    {
        if (!firstJumpObserved)
        {
            firstJumpObserved = true;
            ObserveFirstJump();
        }
    }

    private void ObserveFirstJump() { GravityController.EnableGravity(); }
}
