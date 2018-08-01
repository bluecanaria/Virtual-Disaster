using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour {

    public GameObject locked;
    public GameObject unlock;
    public bool[] UnlockedEnd = new bool[24];

    void EndingUnlock()
    {
        locked.SetActive(false);
        unlock.SetActive(true);
    }

    void SaveEnding()
    {
        if(UnlockedEnd[0] == true)
            PlayerPrefs.SetInt("End1", 1);
        if (UnlockedEnd[1] == true)
            PlayerPrefs.SetInt("End2", 1);
        if (UnlockedEnd[2] == true)
            PlayerPrefs.SetInt("End3", 1);
        if (UnlockedEnd[3] == true)
            PlayerPrefs.SetInt("End4", 1);
        if (UnlockedEnd[4] == true)
            PlayerPrefs.SetInt("End5", 1);
        if (UnlockedEnd[5] == true)
            PlayerPrefs.SetInt("End6", 1);
        if (UnlockedEnd[6] == true)
            PlayerPrefs.SetInt("End7", 1);
        if (UnlockedEnd[7] == true)
            PlayerPrefs.SetInt("End8", 1);
        if (UnlockedEnd[8] == true)
            PlayerPrefs.SetInt("End9", 1);
        if (UnlockedEnd[9] == true)
            PlayerPrefs.SetInt("End10", 1);
        if (UnlockedEnd[10] == true)
            PlayerPrefs.SetInt("End11", 1);
        if (UnlockedEnd[11] == true)
            PlayerPrefs.SetInt("End12", 1);
        if (UnlockedEnd[12] == true)
            PlayerPrefs.SetInt("End13", 1);
        if (UnlockedEnd[13] == true)
            PlayerPrefs.SetInt("End14", 1);
        if (UnlockedEnd[14] == true)
            PlayerPrefs.SetInt("End15", 1);
        if (UnlockedEnd[15] == true)
            PlayerPrefs.SetInt("End16", 1);
        if (UnlockedEnd[16] == true)
            PlayerPrefs.SetInt("End17", 1);
        if (UnlockedEnd[17] == true)
            PlayerPrefs.SetInt("End18", 1);
        if (UnlockedEnd[18] == true)
            PlayerPrefs.SetInt("End19", 1);
        if (UnlockedEnd[19] == true)
            PlayerPrefs.SetInt("End20", 1);
        if (UnlockedEnd[20] == true)
            PlayerPrefs.SetInt("End21", 1);
        if (UnlockedEnd[21] == true)
            PlayerPrefs.SetInt("End22", 1);
        if (UnlockedEnd[22] == true)
            PlayerPrefs.SetInt("End23", 1);
        if (UnlockedEnd[23] == true)
            PlayerPrefs.SetInt("End24", 1);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        SaveEnding();
    }
}
