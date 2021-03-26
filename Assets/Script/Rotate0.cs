using UnityEngine;
using System.Collections;

public class Rotate0 : MonoBehaviour {

    Vector3 pos;
    Quaternion qua;
    Rigidbody rb;
    Transform Tr;
	// Use this for initialization
	void Start () {
        pos = transform.position;
        qua = transform.rotation;
        rb = GetComponent<Rigidbody>();
        Tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        if (GameObject.FindGameObjectWithTag("MainBall").transform.position.y < -19)
        {
            transform.position = pos;
            transform.rotation = qua;
            transform.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            //GetComponent<Rigidbody>() = rb;
            //transform = Tr;
        }
    }
}
