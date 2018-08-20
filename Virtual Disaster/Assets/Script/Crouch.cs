using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{

    GameObject standing;
    GameObject crouching;
    GameObject crouchHead;
    //CapsuleCollider crouchCollider;
    GameObject player;
    float standHeight = 2.5f;
    float crouchHeight = 1.5f;
    float smooth = 0;
    bool isCrouched;
    GameObject cubeCamera;
    Transform stand;
    public float DegreesPerSecond = 1f; // degrees per second
    private Vector3 currentRot, targetRot;
    private bool rotating = false;
    move movement;

    private void Start()
    {
        //player = gameObject.GetComponent<CharacterController>();
        cubeCamera = gameObject.transform.GetChild(0).gameObject;
        player = GameObject.FindGameObjectWithTag("Player");
        //cubeCamera = gameObject.transform.FindChild("Cube").gameObject;
        //Debug.Log(gameObject.transform.GetChild(0).gameObject);
        //Debug.Log(cubeCamera);
        isCrouched = false;
        currentRot = transform.eulerAngles; //플레이어가 바라보는 각도
        movement = player.GetComponent<move>();
    }

    void Update()
    {
        //if (Input.GetKey(KeyCode.X) && isCrouched != true)
        //{
        //    isCrouched = true;
        //}
        //else if (Input.GetKey(KeyCode.X) && isCrouched == true)
        //{
        //    isCrouched = false;
        //}
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
                movement.disable_move = false;
                Debug.Log("crouch");
                stand = cubeCamera.transform;
                stand.position = cubeCamera.transform.position;
                cubeCamera.transform.position = new Vector3(player.transform.position.x , player.transform.position.y-0.3f, player.transform.position.z+0.5f);
                //cubeCamera.transform.RotateAround(transform.position, transform.up, 180f);
                StartCoroutine("Rotate");
                //transform.Rotate(0, Time.deltaTime * 180, 0, Space.Self);
                //transform.RotateAround(transform.position, transform.up, 180f);
                isCrouched = true;

            }
        }
    }

    //IEnumerator Rotate()
    //{
    //    if (!rotating)
    //    {
    //        rotating = true;  // set the flag
    //        targetRot.y = currentRot.y + 180; // calculate the new angle

    //        while (currentRot.y < targetRot.y)
    //        {
    //            //Debug.Log("rotating"+Time.deltaTime);
    //            currentRot.y = Mathf.MoveTowardsAngle(currentRot.y, targetRot.y, DegreesPerSecond * Time.deltaTime); 
    //            cubeCamera.transform.eulerAngles = currentRot;
    //            yield return null;
    //        }

    //        rotating = false;
    //        isCrouched = true;
    //    }
    //}

    IEnumerator Rotate()
    {
        Quaternion startRot = transform.rotation;
        float t = 0.0f;
        while (t < 1f)
        {
            t += Time.deltaTime;
            cubeCamera.transform.rotation = startRot * Quaternion.AngleAxis(t / 1f * 180f, transform.up); //or transform.right if you want it to be locally based
            yield return null;
        }
        //cubeCamera.transform.rotation = startRot;
    }

    IEnumerator turnAround()
    {
        //cubeCamera.transform.Rotate(0, Time.deltaTime * 180, 0, Space.Self);
        cubeCamera.transform.RotateAround(transform.position, transform.up, 180f);
        yield return new WaitForSeconds(1f);
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
