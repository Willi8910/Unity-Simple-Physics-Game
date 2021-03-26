using UnityEngine;
using System.Collections;

public class TransPort : MonoBehaviour {

    public GameObject Destination;
    bool once = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "MainBall")
        {
            if (once == true)
            {
                once = false;
                col.transform.position = new Vector3(Destination.transform.position.x + 3f, Destination.transform.position.y, Destination.transform.position.z);
                
            }
            else
            {
                GameObject gam = GameObject.FindGameObjectWithTag("MainPort");
                col.transform.position = new Vector3(gam.transform.position.x + 3f, gam.transform.position.y, gam.transform.position.z);
            }
            col.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            col.gameObject.GetComponent<Goyang>().StPosition = col.transform.position;

            GameObject Plane = GameObject.FindGameObjectWithTag("Plane");
            Plane.transform.position = new Vector3(col.transform.position.x + 5, col.transform.position.y + 15, col.transform.position.z);

            GameObject Camm = GameObject.FindGameObjectWithTag("MainCamera");
            Camm.transform.position = new Vector3(Plane.transform.position.x + 15, Plane.transform.position.y + 15, Plane.transform.position.z);
        }
    }
}
