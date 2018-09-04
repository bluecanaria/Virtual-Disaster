using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score : MonoBehaviour {

    public GameObject Scores;
    public GameObject SoundSys;

	// Update is called once per frame
	void Update () {

        SoundSys.SetActive(false);

        if (Scores.activeSelf == false && Input.GetButtonUp("Jump"))
        {           
            Scores.SetActive(true);
        }
        else if (Scores.activeSelf && Input.GetButtonUp("Jump"))
            Scores.SetActive(false);
    }
}
