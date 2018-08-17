using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{

    GameObject standing;
    GameObject crouching;
    GameObject crouchHead;
    //CapsuleCollider crouchCollider;
    CharacterController player;
    float standHeight = 2.5f;
    float crouchHeight = 1.5f;
    float smooth = 0;
    bool isCrouched;
    GameObject cubeCamera;

    private void Start()
    {
        //player = gameObject.GetComponent<CharacterController>();
        cubeCamera = gameObject.transform.GetChild(0).gameObject;
        //cubeCamera = gameObject.transform.FindChild("Cube").gameObject;
        Debug.Log(gameObject.transform.GetChild(0).gameObject);
        Debug.Log(cubeCamera);
        isCrouched = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.X) && isCrouched != true)
        {
            isCrouched = true;
        }
        else if (Input.GetKey(KeyCode.X) && isCrouched == true)
        {
            isCrouched = false;
        }
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("collision");
    //    if (collision.gameObject.tag == "table")
    //    {
    //        Debug.Log("table");
    //        x를 누르면 수그린다
    //        if (Input.GetKey(KeyCode.X))
    //        {
    //            Debug.Log("crouch");
    //            isCrouched = true;
    //            cubeCamera.transform.position = new Vector3(0, -0.5f, 0);

    //        }
    //    }
    //}

    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("collision");
        if (collision.gameObject.tag == "table")
        {
            //Debug.Log("table");
            //x를 누르면 수그린다
            if (Input.GetKey(KeyCode.X) && !isCrouched)
            {
                Debug.Log("crouch");
                isCrouched = true;
                cubeCamera.transform.position = new Vector3(0, -0.5f, 0);

            }
        }
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log(other.name);
    //    if (other.gameObject.tag == "table")
    //    {
    //        Debug.Log("table");
    //    }
    //    if (other.gameObject.tag == "Player")
    //    {
    //        Debug.Log("player");
    //    }
    //}
    //private void OnTriggerStay(Collider other)
    //{
    //    Debug.Log("triggerstay");
    //}
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Debug.Log(hit.gameObject.name);
        if (hit.gameObject.tag == "table")
        {
            Debug.Log("table collided");
        }
        if (hit.gameObject.tag == "Player")
        {
            Debug.Log("Player collided");
        }
    }

}
