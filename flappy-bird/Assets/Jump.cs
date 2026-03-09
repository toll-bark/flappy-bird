using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    public Rigidbody2D Rb;

    public float FallMultiplier = 2.5f;
    public float LowJumpMultiplier = 2f;

    InputAction JumpAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        JumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        if (Rb.linearVelocity.y < 0)
        {
            Rb.linearVelocity += (FallMultiplier - 1) * Physics2D.gravity.y * Vector2.up * Time.deltaTime;
        } 
        else if (Rb.linearVelocity.y > 0 && !JumpAction.IsPressed())
        {
            Rb.linearVelocity += (LowJumpMultiplier - 1) * Physics2D.gravity.y * Vector2.up * Time.deltaTime;
        }
    }
}
