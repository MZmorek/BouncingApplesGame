using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject startButton;
    public GameObject gameInfo;
    public GameObject scoreboard;
    private void Start()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        Time.timeScale = 1f;
        DeactivateStartMenuActivateScoreboard();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void DeactivateStartMenuActivateScoreboard()
    {
        startButton.SetActive(false);
        gameInfo.SetActive(false);
        scoreboard.SetActive(true);
    }
    
}
