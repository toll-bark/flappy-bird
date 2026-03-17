using UnityEngine;

public class ObstacleMotion : MonoBehaviour
{
    public int velocity = -10;
    public Lifetime lifetime;
    public ObstacleLifetime obstacleLifetime;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        if (!(lifetime.IsRunning && obstacleLifetime.IsAlive)) { rb.linearVelocityX = 0; }
        else { rb.linearVelocityX = velocity * Time.deltaTime; }
    }
}
