using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

    public GameObject prevent;
    public GameObject nextevent;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.R))
            Tutorial_next();

    }

    void Tutorial_next()
    {
        prevent.SetActive(false);
        nextevent.SetActive(true);
    }

    void Tutorial_Move()
    {
        //if(player.position.x>50 || player.position.x<-50 || player.position.y>50 || player.position.y<-50)
        //
    }
}
