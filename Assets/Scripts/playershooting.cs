using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;   // Reference to the bullet prefab
    public Transform firePoint;       // Position where bullets are fired from
    public float bulletSpeed = 10f;   // How fast the bullet travels

    // 🎵 New audio variables
    public AudioClip shootSound;      // Assign your shoot.wav in Inspector
    private AudioSource audioSource;  // To play the sound

    void Start()
    {
        // 🔊 Initialize AudioSource component
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // When player presses Space, shoot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Create a bullet at the fire point
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Give it velocity
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.right * bulletSpeed;

        // Destroy after 2 seconds to save memory
        Destroy(bullet, 2f);

        // 🎧 Play shooting sound
        if (shootSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(shootSound);
        }
    }
}
