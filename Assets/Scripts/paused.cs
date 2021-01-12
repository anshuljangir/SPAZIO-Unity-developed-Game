using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class paused : MonoBehaviour
{
    Text gamePaused;
    // Start is called before the first frame update
    void Start()
    {
        gamePaused = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pscript.isPaused)
        {
            gamePaused.enabled = true;
        }
        else
        {
            gamePaused.enabled = false;
        }
    }
}
