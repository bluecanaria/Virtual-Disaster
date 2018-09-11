using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange2 : MonoBehaviour {

    public int num;

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene(num);
	}

}
