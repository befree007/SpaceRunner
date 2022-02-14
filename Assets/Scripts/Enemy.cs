using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDestroible
{
    public float speed;
    public GameObject enemy;
    public int enemyHealth = 1;
    private Counter counterKills;
    // Start is called before the first frame update
    void Start()
    {
        counterKills = FindObjectOfType<Counter>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && enemy.tag == "aliveEnemy")
        {
            collision.gameObject.GetComponent<MoveOlayer>().TakeDamage(1);
            Destroy(enemy);
        }
        else if (collision.gameObject.tag == "Player" && enemy.tag == "unaliveEnemy")
        {
            collision.gameObject.GetComponent<MoveOlayer>().TakeDamage(1);
        }
    }

    public void TakeDamage(int damage)
    {
        enemyHealth = enemyHealth - damage;

        if (enemyHealth <= 0)
        {
            counterKills.Kills();
            Destroy(enemy);
        }
    }

    public void DestroyObject()
    {
        Destroy(enemy);
        
        //MoveOlayer.kills += 1;
    }
}
