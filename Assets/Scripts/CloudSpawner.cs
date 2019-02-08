using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour {

    public GameObject[] clouds;
    public float repeatTime;
    int countCloud;
    Vector2 cloudPos;

	void Start () {
        StartCoroutine(CloudSpawn());
    }
	
	void Update () {
        countCloud = Random.Range(0, 15);
        cloudPos = new Vector2(transform.position.x, Random.Range(-5, 5));
    }

    IEnumerator CloudSpawn()
    {
        while (true)
        {
            Instantiate(clouds[countCloud], cloudPos, Quaternion.identity);
            yield return new WaitForSeconds(repeatTime);
        }
    }
}
