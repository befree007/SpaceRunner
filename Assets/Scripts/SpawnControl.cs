using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public List<GameObject> enemies;
    public GameObject enemy;
    public float timeSpawn = 2;
    private int counterChek = 10;
    private int index;

    private float _rndY;

    public GameObject spawner;

    public Counter killsCounter;
    // Start is called before the first frame update
    void Start()
    {        
        StartCoroutine(SpawnObject());
    }
    private void Update()
    {
        IncreasingComplexity();
    }


    void Repeat()
    {        
        StartCoroutine(SpawnObject());        
    }

    IEnumerator SpawnObject()
    {
        index++;
        yield return new WaitForSeconds(timeSpawn);
        //int randomIndex = Random.Range(0, enemies.Count);
        _rndY = Random.Range(3.68f, -3.1f);
        if (index == 4)
        {
            Instantiate(enemies[1], new Vector2(transform.position.x, _rndY), Quaternion.identity);
            index = 0;
        }
        else
        {
            Instantiate(enemies[0], new Vector2(transform.position.x, _rndY), Quaternion.identity);
        }
        Repeat();
    }

    public void IncreasingComplexity()
    {
        if (killsCounter.CounterScores == counterChek)
        {
            counterChek += 10;
            timeSpawn -= 0.2f;
            Debug.Log($"This {timeSpawn}");
        }
        else if (timeSpawn == 0.2f)
        {
            timeSpawn = 0.2f;
            counterChek = 0;
        }
    }
}
