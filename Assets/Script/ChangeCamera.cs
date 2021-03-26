using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {

	// Use this for initialization

    public Camera Cam1;
    public Camera Cam2;
	void Start () {

        Cam1.enabled = true;
        Cam2.enabled = false;
	}
	
    public void Change()
    {
        if (Cam1.enabled == true)
        {
            Cam1.enabled = false;
            Cam2.enabled = true;
        }
        else
        {
            Cam2.enabled = false;
            Cam1.enabled = true;
        }
    }

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
         //   GetComponent<Camera>().camera.ena = false;
            Change();
        }
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray;
            if (Cam1.enabled == true)
            {
                ray = Cam1.ScreenPointToRay(Input.mousePosition);
            }
            else
            {
                ray = Cam2.ScreenPointToRay(Input.mousePosition);
            }
            if (Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "Block")
                Destroy(hit.transform.gameObject);


        }
	}
}
