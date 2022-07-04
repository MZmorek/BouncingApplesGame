using UnityEngine;

public class GameOverConditions : MonoBehaviour
{
    [HideInInspector] public bool hasAppleFallen;
    public GameObject restartButton;


    private void Update()
    {
        restartButton.SetActive(hasAppleFallen);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            hasAppleFallen = true;
            GameOver();
        }
    }

    private void GameOver()
    {
        Time.timeScale = 0;
    }
}
