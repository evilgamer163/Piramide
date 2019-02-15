using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;
    public int bonus = 0;
    public Text bonusCountText;
    public Text timeText;
    public Text loseText;
    public float time = 30;
    public AudioClip[] clips;
    public ParticleSystem[] particles;
    AudioSource source;
    float plusTime;

    public GameObject deathPanel;
    Vector3 move;

	void Start () 
    {
        source = GetComponent<AudioSource>();
        Time.timeScale = 1;
    }
	
	void Update ()
    {
        MovePlayer();
        timeText.text = time.ToString("0");
        bonusCountText.text = bonus.ToString();
        time -= Time.deltaTime;
        plusTime = Random.Range(10, 20);

        GameOver();
    }

    void GameOver()
    {
        if (transform.position.y <= -6)
        {
            Time.timeScale = 0;
            loseText.text = "YOU DEAD";
            deathPanel.SetActive(true);
        }
         else if (time <= 0)
        {
            Time.timeScale = 0;
            loseText.text = "TIME IS OVER";
            deathPanel.SetActive(true);
        }
    }

    void MovePlayer()
    {
        move = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.Translate(move);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bonus"))
        {
            source.clip = clips[0];
            source.Play();
            particles[0].Play();
            bonus++;
            Destroy(collision.gameObject);
        }

        else if (collision.CompareTag("PlusTime"))
        {
            source.clip = clips[1];
            source.Play();
            time += plusTime;
            Destroy(collision.gameObject);
        }
    }
}
