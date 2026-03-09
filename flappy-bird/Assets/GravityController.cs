using UnityEngine;

public class GravityController : MonoBehaviour
{
    public float Gravity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { DisableGravity(); }

    public void EnableGravity() { Physics2D.gravity = Gravity * Vector2.down; }

    public void DisableGravity() { Physics2D.gravity = Vector2.zero; }
}
