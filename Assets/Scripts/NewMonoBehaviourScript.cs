using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;  // Speed of up/down movement
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input for up/down movement (W/S or Arrow Keys)
        float moveY = Input.GetAxisRaw("Vertical");

        // Move the player only on the Y-axis
        rb.linearVelocity = new Vector2(0, moveY * moveSpeed);
    }
}
