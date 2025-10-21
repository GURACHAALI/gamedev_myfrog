using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("UI Elements")]
    public GameObject gameOverPanel;  // assign GameOverPanel here
    public Text scoreText;           // assign ScoreText here

    private bool isGameOver = false;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        if (gameOverPanel != null) gameOverPanel.SetActive(false);
        else Debug.LogError("GameManager: gameOverPanel not assigned!");
    }

    public void GameOver()
    {
        if (isGameOver) return;
        isGameOver = true;

        Debug.Log("GAME OVER TRIGGERED");

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
            Text goText = gameOverPanel.GetComponentInChildren<Text>();
            if (goText != null && scoreText != null)
            {
                goText.text = "GAME OVER\nScore: " + scoreText.text + "\nPress 'R' to Restart";
            }
            else Debug.LogError("GameManager: missing goText or scoreText.");
        }
        else Debug.LogError("GameManager: gameOverPanel is null.");

        Time.timeScale = 0f;
    }

    void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
