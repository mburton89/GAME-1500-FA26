using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    int score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI bestScoreText;

    public GameObject gameOverMenuOverlay;

    private void Awake()
    {
        Instance = this;
        Time.timeScale = 1;
    }

    public void AddPoint()
    {
        score++;
        scoreText.SetText(score.ToString());
        Debug.Log("Score: " + score);
    }

    public void GameOver()
    { 
        gameOverMenuOverlay.SetActive(true);
        //TODO Check for new high score
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
