using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public GameObject Prev;
    public GameObject Next;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonUp("Jump"))
        {
            Prev.SetActive(false);
            Next.SetActive(true);
        }

    }

}
