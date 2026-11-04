using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    int score;

    private void Awake()
    {
        Instance = this;
    }

    public void AddPoint()
    {
        score++;
        Debug.Log("Score: " + score);
    }

    public void GameOver()
    { 
        score = 0; 
        Debug.Log("Score: " + score);
    }
}
