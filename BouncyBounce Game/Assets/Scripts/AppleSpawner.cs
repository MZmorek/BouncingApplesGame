using System.Collections;
using UnityEngine;

public class AppleSpawner : MonoBehaviour
{

    private Coroutine spawningCoroutine;
    public GameObject apple;
    private Vector2 spawnPosition;

    private void Start()
    {
        spawningCoroutine = StartCoroutine(SpawnMoreApples());
    }

    IEnumerator SpawnMoreApples()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            spawnPosition = new Vector2(Random.Range(-18, 15), Random.Range(2, 8));
            Instantiate(apple, spawnPosition, Quaternion.identity);
        }
        
    }
}
