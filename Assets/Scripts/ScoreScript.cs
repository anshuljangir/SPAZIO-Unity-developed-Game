using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int ScoreValue = 0;

    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "SCORE: " + ScoreValue;
        if (PlayerController.isGameOver)
        {
           if(ScoreValue > PlayerPrefs.GetInt("Best"))
            PlayerPrefs.SetInt("Best", ScoreValue);
        }
        
    }
}
