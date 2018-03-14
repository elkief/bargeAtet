using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour {

    public float speed = 25.0f;
    public float rotationSpeed = 90;
    public float force = 700f;
    public float cannonDelay = 0;
    public float cannonDelayTime = 0.25f;

    public GameObject Cannon;
    public GameObject Bullet;
    //public GameObject Info;
    public string restartLevel;

    public bool draggingObject;
    public bool playerOne;

    public GameObject obstacleObject = null;
    public GameObject obstacleObject2 = null;
    public GameObject obstacleObject3 = null;
    public string objectName;
    public Vector3 objectOffset;
    public GameObject player;
    public Score scoreManager;

    private bool canMove = true;

    Rigidbody rb;
    Transform t;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 8 || collision.gameObject.layer == 10)
        {
            Debug.Log("Collisionn detected");
            Physics.IgnoreLayerCollision(0, 8);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && canMove)
            rb.velocity += this.transform.forward * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S) && canMove)
            rb.velocity -= this.transform.forward * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D) && canMove)
            t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.A) && canMove)
            t.rotation *= Quaternion.Euler(0, - rotationSpeed * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.Space) && canMove)
            rb.AddForce(t.up * force);

        if (Input.GetKey(KeyCode.E))
        {
            //draggingObject = true;
            if (objectName != null)
            {
                draggingObject = true;
                obstacleObject = GameObject.Find(objectName);
                //print("Obstacle position: " + obstacleObject.transform.position);
                //objectOffset = obstacleObject.transform.position - transform.position;
                obstacleObject.transform.position = transform.position + objectOffset;
            }
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            draggingObject = false;
        }

        if(player.transform.position.y < 0)
        {
            scoreManager.AddPoint(-8);
            canMove = false;
        }

        /*if(Input.GetKey(KeyCode.I))
        {
            Info.GetComponent<Text>().enabled = true;
        }
        else
        {
            Info.GetComponent<Text>().enabled = false;
        }*/

       /* if (Input.GetButton("Fire1") && Time.time > cannonDelay)
        {
            cannonDelay = Time.time + cannonDelayTime;
            GameObject newBullet = GameObject.Instantiate(Bullet, Cannon.transform.position, Cannon.transform.rotation) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 10;
            newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 1500);
            Physics.IgnoreCollision(newBullet.GetComponent<Collider>(), Cannon.GetComponent<Collider>());
        }*/
    }

   
}
