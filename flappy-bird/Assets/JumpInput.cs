using UnityEngine;
using UnityEngine.InputSystem;

public class JumpInput : MonoBehaviour
{
    public Rigidbody2D rb;
    public int jumpForce;

    InputAction jumpAction;

    bool canJump;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jumpAction = InputSystem.actions.FindAction("Jump");
        jumpAction.Enable();
        canJump = true;
    }

    // Update is called once per frame
    void Update() 
    { 
        if (jumpAction.IsPressed()) OnJumpPress();
        else OnJumpRelease();
    }

    public void OnJumpPress() 
    {
        if (canJump) 
        {
            rb.linearVelocityY = 0f;
            rb.AddForce(new() { x = 0, y = jumpForce }); 
        }
        canJump = false;
    }

    public void OnJumpRelease() 
    { 
        canJump = true;
        // rb.linearVelocityY = Mathf.Min(rb.linearVelocityY, 0f);
    }
}
