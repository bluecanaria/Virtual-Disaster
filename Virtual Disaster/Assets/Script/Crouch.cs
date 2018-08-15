using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{

    //GameObject standing;
    //GameObject crouching;
    //GameObject crouchHead;
    ////CapsuleCollider crouchCollider;
    //CharacterController player;
    //float standHeight = 2.5f;
    //float crouchHeight = 1.5f;
    //float smooth = 0;
    //bool isCrouched;

    //private void Start()
    //{
    //    player = gameObject.GetComponent<CharacterController>();
    //    isCrouched = false;
    //}

    //void Update()
    //{
    //    if (Input.GetKey(KeyCode.X) && isCrouched!=true)
    //    {
    //        isCrouched = true;
    //        player.height = 0.0f;
    //    }
    //    else if(Input.GetKey(KeyCode.X) && isCrouched == true)
    //    {
    //        isCrouched = false;
    //        player.height = 1.7f;
    //    }
    //    //    if (LeftTexture.activeSelf)
    //    //    {
    //    //        RightTexture.SetActive(true);
    //    //        LeftTexture.SetActive(false);
    //    //    }
    //    //    else if (RightTexture.activeSelf)
    //    //    {
    //    //        LeftTexture.SetActive(true);
    //    //        RightTexture.SetActive(false);
    //    //    }


    //    //if (LeftTexture.activeSelf)
    //    //{
    //    //    player.height = crouchHeight;
    //    //    crouchHead.SetActive(true);
    //    //    crouchCollider.enabled = true;
    //    //}

    //    //if (RightTexture.activeSelf)
    //    //{
    //    //    player.height = player.height = Mathf.Lerp(player.height, standHeight, Time.deltaTime * smooth);
    //    //    crouchHead.SetActive(false);
    //    //    crouchCollider.enabled = false;
    //    //}
    //}

    //void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("collision");
    //    if (collision.gameObject.tag == "table")
    //    {
    //        Debug.Log("table");
    //    }
    //}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.gameObject.tag == "table")
        {
            Debug.Log("table");
        }
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("player");
        }
    }
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
