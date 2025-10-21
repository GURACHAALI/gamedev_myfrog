using UnityEngine;

public class BallCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bullet"))
        {
            // Destroy both
            Destroy(other.gameObject);
            Destroy(gameObject);

            // Add score
            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.AddScore(1);
            }
        }
    }
}
