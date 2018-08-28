using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GazeInteraction : MonoBehaviour
{
    private bool gazedAt;

    public GameObject MenuObj;
    public GameObject TitleObj;

    void Update()
    {

        if (gazedAt)
        {
            if (Input.GetButtonUp("Jump"))
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
