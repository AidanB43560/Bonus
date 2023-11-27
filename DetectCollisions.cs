using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private static int lives = 3;
    private static int score = 0;
    private GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        
        playerObject = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other){
        
        if(other.gameObject == playerObject){
            lives -= 1;
            Debug.Log("Lives: " + lives);
            if(lives == 0){
                Debug.Log("GameOver");
                Debug.Log("Final Score " + score);
                Destroy(playerObject);
            }
        }else{
            Destroy(gameObject);
            Destroy(other.gameObject);
            score++;
        }
            

        
    
        
        
    }
    
}
