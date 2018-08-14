using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEndingTest : MonoBehaviour {

    public int number;
    public GameObject locked;
    public GameObject unlock;

    void EndingUnlock()
    {
        locked.SetActive(false);
        unlock.SetActive(true);
    }

    // Use this for initialization
    void Start () {

        //for test
        //PlayerPrefs.DeleteAll();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (number == 1 && PlayerPrefs.GetInt("End1") == 1)
            EndingUnlock();
        if (number == 2 && PlayerPrefs.GetInt("End2") == 1)
            EndingUnlock();
        if (number == 3 && PlayerPrefs.GetInt("End3") == 1)
            EndingUnlock();

    }
}
