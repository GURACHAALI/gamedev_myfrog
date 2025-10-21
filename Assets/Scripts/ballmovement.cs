using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 3f;

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // adjust this threshold to your scene (player x position)
        if (transform.position.x < -9f)
        {
            if (GameManager.Instance != null)
                GameManager.Instance.GameOver();
            else
                Debug.LogError("BallMovement: GameManager.Instance is null!");
            Destroy(gameObject);
        }
    }
}
