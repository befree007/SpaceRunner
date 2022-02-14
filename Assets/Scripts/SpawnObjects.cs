using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public float minYPosition;
    public float maxYPosition;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = new Vector2(transform.position.x + (-1 * speed * Time.deltaTime), transform.position.y);
    }
}
