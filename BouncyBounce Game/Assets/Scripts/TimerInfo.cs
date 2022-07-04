using System.Collections;
using TMPro;
using UnityEngine;

public class TimerInfo : MonoBehaviour
{
    public TMP_Text timerText;
    private int seconds = 1;
    private int minutes;

    private Coroutine timerCoroutine;

    private void Start()
    {
        timerCoroutine = StartCoroutine(ShowMyScore());
    }

    IEnumerator ShowMyScore()
    {
        yield return null;
        timerText.text = $"Your time: {minutes}:{seconds.ToString("00")}";

        while (true)
        {
            yield return new WaitForSeconds(1);
            if (seconds <= 59)
            {
                timerText.text = $"Your time: {minutes}:{seconds.ToString("00")}";
            }
            else
            {
                seconds = 0;
                minutes++;
                timerText.text = $"Your time: {minutes}:{seconds.ToString("00")}";
            }
            
            seconds++;
        }

    }
}
