using TMPro;
using UnityEngine;

public class ScoreInfo : MonoBehaviour
{
    public TMP_Text myScoreText;
    [HideInInspector] public int score = 0;

    private void Update()
    {
        myScoreText.text = $"My Score: {score}";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            score++;
        }
    }
}