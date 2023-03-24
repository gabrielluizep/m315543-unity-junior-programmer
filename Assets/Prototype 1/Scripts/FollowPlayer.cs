using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(0, 5, -7);
    public Vector3 firstPersonOffset = new Vector3(0, 3, -0.5f);
    public bool firstPerson = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            firstPerson = !firstPerson;
        }

        transform.position = player.transform.position + (firstPerson ? firstPersonOffset : offset);
    }
}
