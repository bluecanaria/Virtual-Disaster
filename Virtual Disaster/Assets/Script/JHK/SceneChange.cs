using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {

    public int SceneNum;

	// Use this for initialization
	void Start () {
        SceneManager.LoadScene(SceneNum);
    }
	
}
