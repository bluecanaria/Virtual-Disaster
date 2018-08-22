using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

    public GameObject prevent;
    public GameObject nextevent;
    public GameObject TutorialMenu;
    public GameObject MenuObject;
    public GameObject player;
    public bool TutoMove;
    public bool TutoGetItem;
    public bool TutoOpenInven;
    public bool TutoDropItem;
    public bool TutoCloseInven;
    public bool Tutofinal;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(TutoMove == true)
        {
            player.GetComponent<move>().enabled = true;
            Tutorial_Move();
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

        else if (Tutofinal == true)
        {
            Tutorial_close();
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
          if(player.transform.position.x < -38 || player.transform.position.x > -32)
        {
            player.GetComponent<move>().enabled = false;
            player.transform.position = new Vector3(-35, 1.2f, 30);
            prevent.SetActive(false);
            nextevent.SetActive(true);
        }
    }

    void Tutorial_close()
    {
        prevent.SetActive(false);
        nextevent.SetActive(true);
        TutorialMenu.SetActive(false);
        MenuObject.SetActive(true);
    }
}
