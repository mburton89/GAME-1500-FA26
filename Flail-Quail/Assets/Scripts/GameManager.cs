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

        int currentBestScore = PlayerPrefs.GetInt("BestScore", 0);

        if (score > currentBestScore)
        {
            //Hooray, new high score!
            PlayerPrefs.SetInt("BestScore", score);
            bestScoreText.SetText("New Best Score: " + PlayerPrefs.GetInt("BestScore", 0));
        }
        else 
        {
            bestScoreText.SetText("Best Score: " + PlayerPrefs.GetInt("BestScore", 0));
        }

        Time.timeScale = 0;
    } 

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
