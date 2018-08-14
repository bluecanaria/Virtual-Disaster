using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBack : MonoBehaviour {

    public GameObject Title;
    public GameObject ThisMenu;

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.X))
        {
            Title.SetActive(true);
            ThisMenu.SetActive(false);
        }

    }
}
