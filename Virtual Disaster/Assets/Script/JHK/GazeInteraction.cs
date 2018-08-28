using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GazeInteraction : MonoBehaviour
{
    private bool gazedAt;
    private float timer;
    public float gazeTime = 2f;

    public GameObject MenuObj;
    public GameObject TitleObj;

    void Update()
    {

        if (gazedAt)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                MenuObj.SetActive(true);
                TitleObj.SetActive(false);
            }
        }
        
        //gazedAt = false;

    }

    public void onPointerEnter()
    {
        gazedAt = true;
    }

    public void onPointerExit()
    {
        gazedAt = false;
    }
}
