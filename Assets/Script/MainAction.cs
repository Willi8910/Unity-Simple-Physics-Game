using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainAction : MonoBehaviour {

	// Use this for initialization

    public GameObject[] Bla;

	void Start () {
        //SetAlpha("txtPause", 0);
        SetAlpha(Bla, false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadTutor()
    {
        Application.LoadLevel("Tutor");
    }

    public void Exit()
    {
        Application.Quit();
    }
    private void SetAlpha(GameObject[] nama, bool a)
    {
        for (int i = 0; i < nama.Length; i++)
        {
            nama[i].SetActive(a);
        }
    }

    private void SetAlpha(string nama, float a)
    {
        GameObject g = GameObject.Find(nama);
        g.GetComponent<CanvasRenderer>().SetAlpha(a);
    }
    public void Paused()
    {
      
        if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
           // SetAlpha("txtPause", 0);
            SetAlpha(Bla, false);
            //btn.image.sprite = Conti;
        }
        else
        {
            Time.timeScale = 0;
           // SetAlpha("txtPause", 1);
            SetAlpha(Bla, true);
           // btn.image.sprite = Pause;
        }
        
        //EventSystem.current.SetSelectedGameObject(g);
        GUI.FocusControl(null);
    }

    public void GotoMainMenu()
    {
        Application.LoadLevel("Main Menu");
        
    }

    public void GotoLevel2()
    {
        Application.LoadLevel("Stage2");

    }

    public void GotoLevel1()
    {
        Application.LoadLevel("Stage1");
        
    }

    public void SetVisible(bool tf)
    {
        SetAlpha(Bla, tf);
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "MainBall" && gameObject.tag == "Finish")
        {
            SetAlpha(Bla, true);
        }
    }
}
