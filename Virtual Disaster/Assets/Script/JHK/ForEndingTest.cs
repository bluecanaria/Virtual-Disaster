using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEndingTest : MonoBehaviour {

    public GameObject[] locked = new GameObject[24];
    public GameObject[] unlock = new GameObject[24];

    // Use this for initialization
    void Start () {

        //for test
        //PlayerPrefs.DeleteAll();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (PlayerPrefs.GetInt("End1") == 1)
        {
            locked[0].SetActive(false);
            unlock[0].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End2") == 1)
        {
            locked[1].SetActive(false);
            unlock[1].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End3") == 1)
        {
            locked[2].SetActive(false);
            unlock[2].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End4") == 1)
        {
            locked[3].SetActive(false);
            unlock[3].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End5") == 1)
        {
            locked[4].SetActive(false);
            unlock[4].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End6") == 1)
        {
            locked[5].SetActive(false);
            unlock[5].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End7") == 1)
        {
            locked[6].SetActive(false);
            unlock[6].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End8") == 1)
        {
            locked[7].SetActive(false);
            unlock[7].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End9") == 1)
        {
            locked[8].SetActive(false);
            unlock[8].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End10") == 1)
        {
            locked[9].SetActive(false);
            unlock[9].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End11") == 1)
        {
            locked[10].SetActive(false);
            unlock[10].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End12") == 1)
        {
            locked[11].SetActive(false);
            unlock[11].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End13") == 1)
        {
            locked[12].SetActive(false);
            unlock[12].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End14") == 1)
        {
            locked[13].SetActive(false);
            unlock[13].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End15") == 1)
        {
            locked[14].SetActive(false);
            unlock[14].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End16") == 1)
        {
            locked[15].SetActive(false);
            unlock[15].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End17") == 1)
        {
            locked[16].SetActive(false);
            unlock[16].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End18") == 1)
        {
            locked[17].SetActive(false);
            unlock[17].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End19") == 1)
        {
            locked[18].SetActive(false);
            unlock[18].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End20") == 1)
        {
            locked[19].SetActive(false);
            unlock[19].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End21") == 1)
        {
            locked[20].SetActive(false);
            unlock[20].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End22") == 1)
        {
            locked[21].SetActive(false);
            unlock[21].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End23") == 1)
        {
            locked[22].SetActive(false);
            unlock[22].SetActive(true);
        }
        if (PlayerPrefs.GetInt("End24") == 1)
        {
            locked[23].SetActive(false);
            unlock[23].SetActive(true);
        }

    }
}
