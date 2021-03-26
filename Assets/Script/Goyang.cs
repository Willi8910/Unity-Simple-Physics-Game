using UnityEngine;
using System.Collections;

public class Goyang : MonoBehaviour {
    public Vector3 ar;
    public Vector3 StPosition;
	// Use this for initialization
	void Start () {
        StPosition = transform.position;
        Time.timeScale = 1;

	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeScale == 1)
        {
            GetComponent<Rigidbody>().AddForce(ar);
            if (GetComponent<Transform>().position.y < -20)
            {
                GetComponent<Transform>().position = new Vector3(StPosition.x, StPosition.y, Random.Range(StPosition.z - 8, StPosition.z + 8));
                GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            }

            if (Input.GetKey(KeyCode.O))
            {
                GameObject Plane = GameObject.FindGameObjectWithTag("Plane");
                Plane.transform.position = new Vector3(transform.position.x + 5, transform.position.y + 15, transform.position.z);

                GameObject Camm = GameObject.FindGameObjectWithTag("MainCamera");
                Camm.transform.position = new Vector3(Plane.transform.position.x + 15, Plane.transform.position.y + 15, Plane.transform.position.z);
            }
        }
	}

    void OnCollisionEnter(Collision coll)
    {
        //if(coll.gameObject.name == "Portal")
        //{
        //    GetComponent<Transform>().position = new Vector3(0f, 41f, 0f);
            
        //}
    }
}
