using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class returnScript : MonoBehaviour
{

    public void PreScene()
    {
        //yield return new WaitForSeconds(2f);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.LoadScene("Mainmenu");
        //gameOverText.enabled = false;
        PlayerController.isGameOver = false;
        LivesScript.left = 3;
        ScoreScript.ScoreValue = 0;
        Time.timeScale = 1;
    }
}
