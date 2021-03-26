using UnityEngine;
using System.Collections;

public class tahan : MonoBehaviour {

	// Use this for initialization
    public GameObject Endd;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject == Endd)
        {
            Destroy(this.gameObject);
        }
    }
}
