using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bestgame : MonoBehaviour
{
    Text best_score;
    // Start is called before the first frame update
    void Start()
    {
        best_score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreScript.ScoreValue > PlayerPrefs.GetInt("Best"))
        PlayerPrefs.SetInt("Best",ScoreScript.ScoreValue);

        best_score.text = "BEST: " + PlayerPrefs.GetInt("Best");


    }
}
