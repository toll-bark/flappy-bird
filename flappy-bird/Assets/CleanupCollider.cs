using UnityEngine;

public class CleanupCollider : MonoBehaviour
{
    public GameObject parent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ObstacleCleanup")) { Destroy(parent); }
    }
}
