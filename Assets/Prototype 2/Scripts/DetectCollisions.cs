using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) {
            if(gameObject.tag == "Projectile") return;
            
            other.gameObject.GetComponent<PlayerControllerP2>().SetLives(other.gameObject.GetComponent<PlayerControllerP2>().GetLives() - 1);

            if(other.gameObject.GetComponent<PlayerControllerP2>().GetLives() < 1) {
                Debug.Log("Game Over!");
                Destroy(other.gameObject);
            } else {
                Debug.Log("Lives: " + other.gameObject.GetComponent<PlayerControllerP2>().GetLives());
            }

            Destroy(gameObject);
        } else {
            if(gameObject.tag == "Projectile") {
            player.GetComponent<PlayerControllerP2>().SetScore(player.GetComponent<PlayerControllerP2>().GetScore() + 10);
            
            Debug.Log("Score: " + player.GetComponent<PlayerControllerP2>().GetScore());
}

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
