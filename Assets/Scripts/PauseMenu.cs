using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    [SerializeField] Image image;
    [SerializeField] Sprite[] sprites;
    [SerializeField] GameObject pausePanel;
    [SerializeField] GameObject button;

    bool soundController = true;

    void Start () {
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

    public void PauseButton()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0.0000000001f;
            pausePanel.SetActive(true);
            button.SetActive(false);
        }
        else
        {
            Time.timeScale = 1;
            pausePanel.SetActive(false);
            button.SetActive(true);
        }
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
}
