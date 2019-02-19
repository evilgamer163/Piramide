using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSpawner : MonoBehaviour {

    public GameObject[] rain;
    Vector3 rainSpawn;
    int randomRain;

	void Start () {
        StartCoroutine(SpawnerRain());
	}
	
	void Update () {
        randomRain = Random.Range(0, 30);
        rainSpawn = new Vector3(Random.Range(-9, 9), transform.position.y);
	}

    IEnumerator SpawnerRain()
    {
        while (true)
        {
            Instantiate(rain[randomRain], rainSpawn, Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
