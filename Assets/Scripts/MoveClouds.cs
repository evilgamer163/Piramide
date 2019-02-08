using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClouds : MonoBehaviour {

    float speed;
	
	void Update () {
        speed = Random.Range(1, 3);

        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < -12)
        {
            Destroy(gameObject);
        }
    }
}
