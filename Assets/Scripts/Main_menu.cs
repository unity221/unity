using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    public void Play(){
        // SceneManager.LoadScene(ScenceManager.GetActiveScence().buildIndex + 1);
        SceneManager.LoadScene("Game");
    }

    public void Quit(){
        Application.Quit();
        Debug.Log("Player has quit the game");
    }
}
