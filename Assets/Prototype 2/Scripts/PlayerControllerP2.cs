using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerP2 : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xMax = 20;
    public float xMin = -20;
    public float zMax = 15;
    public float zMin = -1;

    public int lives = 3;
    public int score = 0;

    public GameObject projectilePrefab;

    public int GetLives(){
        return lives;
    }

    public int SetLives(int newLives) {
        return lives = newLives ;
    }   

    public int GetScore(){
        return score;
    }

    public int SetScore(int newScore) {
        return score = newScore;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < xMin)
        {
            transform.position = new Vector3(xMin, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xMax)
        {
            transform.position = new Vector3(xMax, transform.position.y, transform.position.z);
        }

         if(transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin);
        }

        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }

        if(Input.GetKeyDown(KeyCode.Space)){
           GameObject newBullet = Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);

           newBullet.GetComponent<DetectCollisions>().player = gameObject;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
}
