using UnityEngine;
using System.Collections;

public class CreatePath : MonoBehaviour {

    public GameObject Obs1;
    public GameObject Obs2;

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
            Destroy(Obs1, 6f);
            Destroy(Obs2, 7f);
        }
    }
}
