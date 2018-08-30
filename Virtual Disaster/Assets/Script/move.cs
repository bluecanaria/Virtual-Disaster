using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {


    public float speed = 4;

    //for movement
    private Vector3 pos;
    private Vector3 pos2;
    public bool disable_move;
    public GameObject Inventory;

    private Rigidbody rb;
    private Transform vrCamera;

    // Use this for initialization
    void Start () {
        disable_move = true;
        rb = GetComponent<Rigidbody>();
        vrCamera= Camera.main.transform; 
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //Vector3 movement= speed * new Vector3(vrCamera.TransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).x, 0f, vrCamera.TransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).z);
        //movement.y = rb.velocity.y;
        //rb.velocity = movement;
        if(Inventory.GetComponent<inventory>().total_weight<20)
        {
            speed = 4;
        }
        else if(Inventory.GetComponent<inventory>().total_weight < 40)
        {
            speed = 3.5f;
        }
        else if (Inventory.GetComponent<inventory>().total_weight <60)
        {
            speed = 3f;
        }
        else if (Inventory.GetComponent<inventory>().total_weight < 80)
        {
            speed = 2f;
        }
        else if (Inventory.GetComponent<inventory>().total_weight < 100)
        {
            speed = 1f;
        }
        else if (Inventory.GetComponent<inventory>().total_weight >= 100)
        {
            speed = 0;
        }
        //pos = transform.position;
        if (disable_move)
            movePlayer();      

    }

    public void movePlayer()
    {
        Vector3 movement = speed * new Vector3(vrCamera.TransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).x, 0f, vrCamera.TransformDirection(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).z);
        movement.y = rb.velocity.y;
        rb.velocity = movement;
    }

    //public void movee()
    //{

    //    if (Input.GetKey(KeyCode.W)) //앞
    //    {
    //            //pos += Vector3.forward;
    //            pos2 = pos + transform.forward;
    //        transform.position = Vector3.MoveTowards(transform.position, pos2, Time.deltaTime * speed);

    //    }
    //    else if (Input.GetKey(KeyCode.S)) //Down
    //    {
    //            pos2 = pos - transform.forward;
    //        transform.position = Vector3.MoveTowards(transform.position, pos2, Time.deltaTime * speed);

    //    }
    //    else if (Input.GetKey(KeyCode.A)) //Left
    //    {
          
    //            pos2 = pos - transform.right;
    //        transform.position = Vector3.MoveTowards(transform.position, pos2, Time.deltaTime * speed);

    //    }
    //    else if (Input.GetKey(KeyCode.D)) //Right
    //    {

    //            pos2 = pos + transform.right;
    //        transform.position = Vector3.MoveTowards(transform.position, pos2, Time.deltaTime * speed);
    //    }

    //}
}
