using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {

    public void RestartGame(int numberScene) 
    {
        SceneManager.LoadScene(numberScene);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

}
