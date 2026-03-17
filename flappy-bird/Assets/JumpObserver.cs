using UnityEngine;

public class JumpObserver : MonoBehaviour
{
    public Lifetime lifetime;
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

    private void ObserveFirstJump() 
    {
        lifetime.EnableRuntime();
        GravityController.EnableGravity(); 
    }
}
