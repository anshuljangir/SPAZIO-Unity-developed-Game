using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using System.Collections;

public class OverScript : MonoBehaviour
{
    public bool checker = false;
    //public bool isGameOver;
    Text gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOver").GetComponent<Text>();
    }
        // Update is called once per frame
    void Update()
    {
        if (PlayerController.isGameOver)
        {
            gameOverText.enabled = true;
            Time.timeScale = 0.0F; //game over
              
            
          
        }
    }
    
}
