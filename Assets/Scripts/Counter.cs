using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text PlayerHealth;
    public Text EnemyCounter;
    public int CounterLives = 0;
    public int CounterScores;

    public MoveOlayer moveOlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LivesCounter();
        KillsCounter();
    }

    public void LivesCounter()
    {
        if (CounterLives != moveOlayer.fullHealth)
        {
            CounterLives = moveOlayer.fullHealth;
            PlayerHealth.text = "Health: " + CounterLives.ToString();
        }
    }

    public void Kills()
    {
        CounterScores++;
        moveOlayer.kills = CounterScores;
    }

    public void KillsCounter()
    {
        EnemyCounter.text = "Enemy kills: " + CounterScores.ToString();
    }
}
