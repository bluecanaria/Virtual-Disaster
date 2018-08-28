using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {

    public GameObject prevent;
    public GameObject nextevent;
    public GameObject TutorialMenu;
    public GameObject MenuObject;
    public GameObject player;
    public GameObject Medkit;
    public GameObject Medkit_inven;
    public GameObject EventSyst;
    public GameObject table;

    public bool TutoMove;
    public bool TutoGetItem;
    public bool TutoOpenInven;
    public bool TutoDropItem;
    public bool TutoCrouch;
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
            Tutorial_GetItem();
        }

        else if (TutoOpenInven == true)
        {
            EventSyst.GetComponent<inventory>().enabled = true;
            Tutorial_OpenInven();
        }

        else if (TutoDropItem == true)
        {
            Tutorial_DropItem();
        }

        else if (TutoCrouch == true)
        {
            Tutorial_crouch();
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

    void Tutorial_GetItem()
    {
        Medkit.SetActive(true);
        player.GetComponent<move>().enabled = true;
        player.GetComponent<pickup>().enabled = true;
        //EventSyst.GetComponent<inventory>().enabled = true;


        if (Medkit_inven.activeSelf)
        {
            prevent.SetActive(false);
            nextevent.SetActive(true);
            player.GetComponent<move>().enabled = false;
            player.GetComponent<pickup>().enabled = false;
        }
    }

    void Tutorial_OpenInven()
    {
        EventSyst.GetComponent<inventory>().enabled = true;
        player.GetComponent<pickup>().enabled = true;

        if (player.transform.position.y > 30)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                prevent.SetActive(false);
                nextevent.SetActive(true);
                EventSyst.GetComponent<inventory>().enabled = false;
                player.GetComponent<pickup>().enabled = false;
            }

        }
    }

    void Tutorial_DropItem()
    {
        EventSyst.GetComponent<inventory>().enabled = true;
        player.GetComponent<pickup>().enabled = true;

        if (Medkit_inven.activeSelf == false && player.transform.position.y < 10)
        {
            prevent.SetActive(false);
            nextevent.SetActive(true);
            player.GetComponent<pickup>().enabled = false;
            EventSyst.GetComponent<inventory>().enabled = false;
        }
    }

    void Tutorial_crouch()
    {
        Medkit.SetActive(false);
        table.SetActive(true);
        player.GetComponent<move>().enabled = true;

        if (player.GetComponent<Crouch>().isCrouched == true)
        {
            player.GetComponent<move>().enabled = false;
            player.GetComponent<Crouch>().enabled = false;
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
