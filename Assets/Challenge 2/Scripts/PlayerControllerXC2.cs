using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerXC2 : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown = 1.0f;
    private float lastShot = 0.0f;

    void Start()
    {
        lastShot = Time.time;   
    }
    
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > lastShot + cooldown)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            lastShot = Time.time;
        }
    }
}
