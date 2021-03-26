using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class Flying : MonoBehaviour {

    public GameObject Cuber;
    ArrayList kumpul = new ArrayList();

    public Camera MCamera;

    public Material[] Mat;
	// Use this for initialization

    float batasMin = 10f; // ini perbedaan minimal antara camera dan pesawat

    bool Mundur = false;

    float batasMax = 30f; // ini perbedaan minimal antara camera dan pesawat

    bool Maju = false;

    float fc = 10;

	void Start () {
       
	}
	

   
	// Update is called once per frame
	void FixedUpdate () {

        GameObject Balll = GameObject.FindGameObjectWithTag("MainBall");
       
        Vector3 ArahP = new Vector3();
        //Vector3 ArahB = new Vector3();
        float xy = 0.3f;
	    if(Input.GetKey(KeyCode.A))
        {
            if (MCamera.enabled == false) 
                ArahP = new Vector3(0, 0, -xy);
            else
            {
                Balll.GetComponent<Rigidbody>().AddForce(0, 0, -fc);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (MCamera.enabled == false) 
                ArahP = new Vector3(xy, 0, 0);
            else
            {
                Balll.GetComponent<Rigidbody>().AddForce(fc, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            if (MCamera.enabled == false) 
                ArahP = new Vector3(-xy, 0, 0);
            else
            {
                Balll.GetComponent<Rigidbody>().AddForce(-fc, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (MCamera.enabled == false) 
                ArahP = new Vector3(0, 0, xy);
            else
            {
                Balll.GetComponent<Rigidbody>().AddForce(0, 0, fc);
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (MCamera.enabled == false) 
                ArahP = new Vector3(0, 0.2f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y - Balll.transform.position.y > 10)
        {
            //if (GetComponent<Transform>().position.y > 40) 
            if (MCamera.enabled == false) 
                ArahP = new Vector3(0, -0.2f, 0);
        }
        GetComponent<Transform>().position += ArahP;

        Vector3 Ppesawat = GetComponent<Transform>().position;
        Vector3 Cam = MCamera.GetComponent<Transform>().position;

        if ((Cam.x - Balll.transform.position.x < 18f && MCamera.enabled == true)) 
        {
            Mundur = true;
        }

        if(Mundur == true)
        {
            if ((Cam.x - Balll.transform.position.x < 27f && MCamera.enabled == true))
            {
                Vector3 naik = new Vector3(xy + xy/2, 0,0);
                MCamera.GetComponent<Transform>().position += naik;
            }
            else
            {
                Mundur = false;
            }
        }


        if ((Cam.x - Balll.transform.position.x > 35f && MCamera.enabled == true))
        {
            Maju = true;
        }

        if (Maju == true)
        {
            if ((Cam.x - Balll.transform.position.x > 30f && MCamera.enabled == true))
            {
                Vector3 naik = new Vector3(xy + xy / 2, 0, 0);
                MCamera.GetComponent<Transform>().position -= naik;
            }
            else
            {
                Maju = false;
            }
        }
        GUI.FocusControl(null);
	}

    public void FallBlock()
    {
        Vector3 Pos = GetComponent<Transform>().position;
        if (Time.timeScale == 1)
        {
            GUI.FocusControl(null);
            GameObject gamer = (GameObject)Instantiate(Cuber, new Vector3(Pos.x, Pos.y - 1.5f, Pos.z), Quaternion.identity);
            kumpul.Add(gamer);
            int idx = Random.Range(0, Mat.Length);
            gamer.GetComponent<Renderer>().material = Mat[idx];
        }
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            FallBlock();
        }
        if(Input.GetKeyDown(KeyCode.Delete))
        {
            foreach(object ob in kumpul)
            {
                GameObject gam = (GameObject)ob;
                Destroy(gam);
            }
            kumpul.Clear();
        }
    }
}
