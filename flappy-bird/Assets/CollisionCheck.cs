using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public Lifetime Lifetime;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LoseCollider")) { Lifetime.IsRunning = false; }
    }
}
