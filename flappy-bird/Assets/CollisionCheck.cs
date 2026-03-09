using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public Lifetime Lifetime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("LoseCollider"))
        {
            Debug.Log("floor hit");
            Lifetime.IsRunning = false;
        }
    }
}
