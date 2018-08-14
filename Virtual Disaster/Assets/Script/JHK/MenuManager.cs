using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public GameObject Title;
    public GameObject Menu;
    public GameObject ThisButton;
    public GameObject UpButton;
    public GameObject DownButton;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
            OpenMenu();

        if (Input.GetKeyDown(KeyCode.UpArrow))
            KeyUp();

        if (Input.GetKeyDown(KeyCode.DownArrow))
            KeyDown();
    }

    void OpenMenu()
    {
        Title.SetActive(false);
        Menu.SetActive(true);
    }

    void KeyUp()
    {
        ThisButton.SetActive(false);
        UpButton.SetActive(true);
    }

    void KeyDown()
    {
        ThisButton.SetActive(false);
        DownButton.SetActive(true);
    }
}
