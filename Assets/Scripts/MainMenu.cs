using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void JewLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void PadikLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void HellLevel()
    {
        SceneManager.LoadScene(3);
    }

    public void RobotLevel()
    {
        SceneManager.LoadScene(4);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
