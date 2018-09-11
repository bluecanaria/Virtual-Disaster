using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SceneChange : MonoBehaviour
{
    AsyncOperation async_operation;
    public Image loading;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(StartLoad("modified_schoolScene"));
        // SceneManager.LoadScene("LoadingScene");
    }

    //public void onClick()
    //{
    //    SceneManager.LoadScene("LoadingScene");

    //    //LoadingScene
    //    //modified_schoolScene
    //}


    public IEnumerator StartLoad(string strSceneName)
    {
        loading.gameObject.SetActive(true);
        GameObject player = GameObject.Find("Player");
        player.transform.position = new Vector3(4,8,-31);

        async_operation = SceneManager.LoadSceneAsync(strSceneName);
        //async_operation.allowSceneActivation = false;
        while (!async_operation.isDone)
        {
            yield return null;
        }
        //if (IsDone == false)
        //{
        //    IsDone = true;

        //    while (async_operation.progress < 0.9f)
        //    {

        //        yield return true;
        //    }
        //}
        yield return null;
    }

}

