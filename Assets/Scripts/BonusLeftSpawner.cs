using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BonusLeftSpawner : MonoBehaviour {

    public GameObject bonus;
    Vector3 spawnLeftPosition;
    float spawnTime;

	void Start () {
        StartCoroutine(SpawnBonus());
	}
	
	void Update () {
        spawnLeftPosition = new Vector3(Random.Range(-3.5f, -1), transform.position.y);
        spawnTime = Random.Range(0, 1f);
    }

    IEnumerator SpawnBonus()
    {
        while (true)
        {
            Instantiate(bonus, spawnLeftPosition, Quaternion.identity);
            yield return new WaitForSeconds(spawnTime);
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(0);
    }
}
