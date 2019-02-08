using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rain : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
        transform.Translate(Vector2.down * 5 * Time.deltaTime);
        if (transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }
}
