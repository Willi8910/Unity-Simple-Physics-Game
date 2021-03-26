using UnityEngine;
using System.Collections;

public class clicker : MonoBehaviour {

	// Use this for initialization
 
    public void Ubah()
    {
        Application.LoadLevel("Stage2");
    }
    void onClick()
    {
        Debug.Log("Sudah di klik");

       
    }
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
