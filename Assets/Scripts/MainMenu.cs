using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    [SerializeField] Image image;
    [SerializeField] Sprite[] sprites;
    [SerializeField] GameObject howToPlayPanel;
    [SerializeField] Text howToPlayButtonText;

    bool soundController = true;

    void Start()
    {
        if (AudioListener.volume == 0)
        {
            soundController = false;
            image.sprite = sprites[0];
        }
        else
        {
            soundController = true;
            image.sprite = sprites[1];
        }
    }

    public void HowToPlayPanel()
    {
        if (howToPlayPanel.activeSelf)
        {
            howToPlayPanel.SetActive(false);
            howToPlayButtonText.text = " HOW TO \nPLAY?";

        }
        else
        {
            howToPlayPanel.SetActive(true);
            howToPlayButtonText.text = "BACK";
        }
    }

    public void LoadScene(int i)
    {
        SceneManager.LoadScene(i);
        PlayerPrefs.GetFloat("volume", AudioListener.volume);
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
