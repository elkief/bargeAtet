using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkControlPlayer : NetworkBehaviour {

    public float speed = 25.0f;
    public float rotationSpeed = 90;
    public float force = 700f;

    public GameObject moveTrigger = null;

    public GameObject nameToHide = null;

    public GameObject[] renderColorChange;

    [SyncVar]
    public string playerName = "Player Name";

    [SyncVar]
    public Color playerColor = Color.blue;
    
    Rigidbody rb;
    Transform t;

    public bool canMove;

    private void OnGUI()
    {
        if(isLocalPlayer)
        {
            playerName = GUI.TextField(new Rect(25, Screen.height - 40, 100, 30), playerName);
            if(GUI.Button(new Rect(130, Screen.height - 40, 80, 30), "Change"))
            {
                CmdChangeName(playerName);
            }
        }            
    }

    [Command]
    public void CmdChangeName(string newName)
    {
        playerName = newName;
    }

    // Use this for initialization
    void Start () {

        if (isLocalPlayer)
        {
            moveTrigger.SetActive(false);

            nameToHide.SetActive(false);

            canMove = true;
            Camera.main.transform.position = this.transform.position - this.transform.forward * 5 + this.transform.up * 2;
            //Camera.main.transform.position = this.transform.position + this.transform.up * 2;
            Camera.main.transform.LookAt(this.transform.position);
            Camera.main.transform.parent = this.transform;

            if (playerColor == Color.red)
            {
                this.transform.position = new Vector3(150, 15, 150);
            }
            else if (playerColor == Color.blue)
            {
                this.transform.position = new Vector3(-150, 15, 150);
            }
            else if (playerColor == Color.green)
            {
                this.transform.position = new Vector3(150, 15, -150);
            }
            else
            {
                this.transform.position = new Vector3(-250, 15, -250);
                moveTrigger.SetActive(true);
            }
        }
        else
        {
            canMove = false;
        }
        
        foreach(GameObject gO in renderColorChange)
        {
            Renderer[] rends = gO.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in rends)
            {
                r.material.color = playerColor;
            }
        }        

        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        if (nameToHide.activeSelf == true)
        {
            this.GetComponentInChildren<TextMesh>().text = playerName;
        }        

        if (canMove)
        {
            if (Input.GetKey(KeyCode.W))
                rb.velocity += this.transform.forward * speed * Time.deltaTime;
            else if (Input.GetKey(KeyCode.S))
                rb.velocity -= this.transform.forward * speed * Time.deltaTime;

            if (Input.GetKey(KeyCode.D))
                t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
            else if (Input.GetKey(KeyCode.A))
                t.rotation *= Quaternion.Euler(0, -rotationSpeed * Time.deltaTime, 0);

            if (Input.GetKeyDown(KeyCode.Space))
                rb.AddForce(t.up * force);//*/
        }
	}
}
