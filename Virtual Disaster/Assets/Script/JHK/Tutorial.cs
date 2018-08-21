using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

    public GameObject prevent;
    public GameObject nextevent;
    public bool TutoMove;
    public bool TutoGetItem;
    public bool TutoOpenInven;
    public bool TutoDropItem;
    public bool TutoCloseInven;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(TutoMove == true)
        {

        }

        else if (TutoGetItem == true)
        {

        }

        else if (TutoOpenInven == true)
        {

        }

        else if (TutoDropItem == true)
        {

        }

        else if (TutoCloseInven == true)
        {

        }

        else
        {
            Tutorial_next();
        }

    }

    void Tutorial_next()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            prevent.SetActive(false);
            nextevent.SetActive(true);
        }
    }

    void Tutorial_Move()
    {
        //if(player.position.x>50 || player.position.x<-50 || player.position.y>50 || player.position.y<-50)
        //
    }
}
