using UnityEngine;
using TMPro; // Needed for TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Singleton reference for global access
    public TextMeshProUGUI scoreText;
    private int score = 0;

    void Awake()
    {
        // Ensures only one ScoreManager exists
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score.ToString();
    }
}
