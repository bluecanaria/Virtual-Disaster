using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {
    GameObject UI;
    //public GameObject defaultUI;
    public GameObject evacUI_1;
    public GameObject evacUI_2;

    private void Awake()
    {
        UI = gameObject;
        //defaultUI = gameObject.transform.Find("Default").gameObject;
        evacUI_1 = gameObject.transform.Find("Evacuation_1").gameObject;
        evacUI_2 = gameObject.transform.Find("Evacuation_2").gameObject;
    }

    // Use this for initialization
    void Start () {
        //defaultUI.SetActive(true);
        evacUI_1.SetActive(false);
        evacUI_2.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
