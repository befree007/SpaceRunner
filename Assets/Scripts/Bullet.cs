using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public int kills;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "aliveEnemy")
        {
            collision.gameObject.GetComponent<Enemy>().TakeDamage(1);
            Destroy(bullet);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "DeathZone")
        {            
            Destroy(bullet);
        }
    }
}
