using UnityEngine;
using System.Collections;

public class GetPlatform : MonoBehaviour {

    public GameObject mv;
    bool start = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void FixedUpdate()
    {
        if (start == true)
        {
            if (mv.GetComponent<Transform>().localPosition.x > 75)
            {
                mv.GetComponent<Transform>().position = new Vector3(mv.GetComponent<Transform>().position.x - 1, mv.GetComponent<Transform>().position.y, mv.GetComponent<Transform>().position.z);
            }
            else
            { start = false; }
        }
    }
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "MainBall")
        {
            start = true;
        }
    }
}
