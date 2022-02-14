using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSpeed : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in transform)
        {
            if (child.position.x <= -22.15f)
            {
                child.position = new Vector3(25.75f, child.position.y, child.position.z);
            }
            else
            {
                child.position = new Vector3(child.position.x - speed * Time.deltaTime, child.position.y, child.position.z);
            }
        }
    }
}
