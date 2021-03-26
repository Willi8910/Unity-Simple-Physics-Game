using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
    Vector3 pos;
    Quaternion qua;
	// Use this for initialization
	void Start () {
        pos = transform.position;
        qua = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
	    if(GameObject.FindGameObjectWithTag("MainBall").transform.position.y < -20)
        {
            transform.position = pos;
            transform.rotation = qua;
        }
	}
}
