using UnityEngine;
using System.Collections;

public class Directional : MonoBehaviour {

    public Vector3 Dir;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "MainBall")
        {
            coll.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(coll.gameObject.GetComponent<Rigidbody>().velocity.x / 4, coll.gameObject.GetComponent<Rigidbody>().velocity.y, coll.gameObject.GetComponent<Rigidbody>().velocity.z);
            coll.gameObject.GetComponent<Rigidbody>().AddForce(Dir * 40f);
        }
    }
}
