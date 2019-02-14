using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    [SerializeField] Image image;
    [SerializeField] Sprite[] sprites;

    bool soundController = true;

    public void LoadScene(int i)
    {
        SceneManager.LoadScene(i);
    }

    public void SoundButton()
    {
        if (soundController == true)
        {
            AudioListener.volume = 0;
            soundController = false;
            image.sprite = sprites[0];

        }
        else
        {
            AudioListener.volume = 1;
            soundController = true;
            image.sprite = sprites[1];
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
