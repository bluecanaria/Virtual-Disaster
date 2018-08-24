using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chairMove : MonoBehaviour {

    private Vector3 startPos;
    private Vector3 endPos;
    //private float distance = 0.5f;
    private float lerpTime = 0.5f;//움직이는데 걸리는 시간
    private float currentLerpTime = 0;
    private bool moved = false;
    public float distance;

	// Use this for initialization
	void Start () {
        startPos = gameObject.transform.position;
        endPos = gameObject.transform.position + Vector3.up * distance;

	}
	
	// Update is called once per frame
	void Update () {
        //currentLerpTime += Time.deltaTime;
        //if(currentLerpTime > lerpTime)
        //{
        //    currentLerpTime = lerpTime;
        //}

        //float perc = currentLerpTime / lerpTime;

        //gameObject.transform.position = Vector3.Lerp(startPos, endPos, perc);
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player" && !moved)
        {
            Debug.Log("chair");
            gameObject.transform.parent.position -= transform.right * distance;
            moved = true;
            //transform.parent.position-= transform.forward * 0.4f;
        }
    }
}
