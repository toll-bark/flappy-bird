using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    public Rigidbody2D Rb;
    public Lifetime Lifetime;

    public int jumpForce = 375;
    public float FallMultiplier = 2.5f;
    public float LowJumpMultiplier = 2f;

    InputAction JumpAction;

    private bool canJump;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        JumpAction = InputSystem.actions.FindAction("Jump");
        JumpAction.Enable();
        canJump = true;

        Physics2D.gravity = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (Lifetime.IsRunning)
        {
            if (Rb.linearVelocity.y < 0) { Rb.linearVelocity += (FallMultiplier/* - 1*/) * Physics2D.gravity.y * Time.deltaTime * Vector2.up; }
            else if (Rb.linearVelocity.y > 0 && !JumpAction.IsPressed()) { Rb.linearVelocity += (LowJumpMultiplier/* - 1*/) * Physics2D.gravity.y * Time.deltaTime * Vector2.up; }

            if (JumpAction.IsPressed()) OnJumpPress();
            else OnJumpRelease();
        }
    }

    public void OnJumpPress()
    {
        Physics2D.gravity = Vector2.down * 10;
        if (canJump)
        {
            Rb.linearVelocityY = 0f;
            Rb.AddForce(new() { x = 0, y = jumpForce });
        }
        canJump = false;
    }

    public void OnJumpRelease() { canJump = true; }
}
