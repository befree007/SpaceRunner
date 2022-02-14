using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpikeControl : MonoBehaviour
{
    public GameObject upSpike;
    public GameObject downSpike;
    public float upYPoint;
    public float downYPoint;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Repeat()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        int randomEnemy = Random.Range(1,3);
        yield return new WaitForSeconds(3);
        if (randomEnemy == 1)
        {
            Instantiate(upSpike, new Vector2(transform.position.x, upYPoint), Quaternion.identity);
        }
        else
        {
            Instantiate(downSpike, new Vector2(transform.position.x, downYPoint), Quaternion.identity);
        }
        
        Repeat();
    }
}
