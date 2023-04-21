using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 35;
    private float lowerBound = -15;
    private float rightBound = 25;
    private float leftBound = -25;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound || transform.position.z < lowerBound || transform.position.x > rightBound || transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
