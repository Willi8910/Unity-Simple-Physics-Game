using UnityEngine;
using System.Collections;

public class ScBalok : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(GetComponent<Transform>().position.y < -10)
        {
            Destroy(gameObject);
        }
	}
}
