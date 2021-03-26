using UnityEngine;
using System.Collections;

public class RunRun : MonoBehaviour {

    public float Lim;
    float norm;
    public float spd;
	// Use this for initialization
	void Start () {
        norm = GetComponent<Transform>().position.z;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void FixedUpdate()
    {
        GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z + spd);
        if(GetComponent<Transform>().position.z < norm-Lim || GetComponent<Transform>().position.z > norm+Lim)
        {
            spd *= -1;
        }
    }
}
