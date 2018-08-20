using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {


    private int speed = 1;

    //for movement
    private Vector3 pos;
    private Vector3 pos2;
    public bool disable_move;

    // Use this for initialization
    void Start () {
        disable_move = true;
	}
	
	// Update is called once per frame
	void Update () {

        pos = transform.position;
        if(disable_move)
            movee();  

    }



    public void movee()
    {

        if (Input.GetKey(KeyCode.W)) //앞
        {
                //pos += Vector3.forward;
                pos2 = pos + Vector3.forward;
            transform.position = Vector3.MoveTowards(transform.position, pos2, Time.deltaTime * speed);

        }
        else if (Input.GetKey(KeyCode.S)) //Down
        {
                pos2 = pos + Vector3.back;
            transform.position = Vector3.MoveTowards(transform.position, pos2, Time.deltaTime * speed);

        }
        else if (Input.GetKey(KeyCode.A)) //Left
        {
          
                pos2 = pos + Vector3.left;
            transform.position = Vector3.MoveTowards(transform.position, pos2, Time.deltaTime * speed);

        }
        else if (Input.GetKey(KeyCode.D)) //Right
        {

                pos2 = pos + Vector3.right;
            transform.position = Vector3.MoveTowards(transform.position, pos2, Time.deltaTime * speed);
        }

    }
}
