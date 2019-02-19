using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusTimeSpawner : MonoBehaviour {

    public GameObject plusTime;
    float randomTimeSpawn;
	
	void Start () {
        StartCoroutine(PlusTimeSpawn());
	}
	
	void Update () {
        randomTimeSpawn = Random.Range(5f, 15f);
	}

    IEnumerator PlusTimeSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(randomTimeSpawn);
            Instantiate(plusTime, transform.position, Quaternion.identity);
        }
    }
}