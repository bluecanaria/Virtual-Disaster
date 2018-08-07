﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{

    public GameObject invLight;
    public GameObject mainCamera;
    public GameObject player;
    move movement;
    pickup pick;

    private bool inven;
    private Vector3 player_posi;



    ///물ㄹ건들 
    public GameObject Bottle_1;
    public GameObject Candy_Bar;

    // Use this for initialization
    private void Awake()
    {
        inven = false;
        invLight.SetActive(false);
        movement = player.GetComponent<move>();
        pick = player.GetComponent<pickup>();

    }

    // Update is called once per frame
    void Update()
    {
        //인벤토리 켜기 
        if (Input.GetKeyDown(KeyCode.R)) {
            if (inven == false)
            {
                invLight.SetActive(true);
                inven = true;
                pick.pick = false;
                player_posi = player.transform.position;
                pick.player_place = player_posi;
                player.transform.position = new Vector3(960, 651, -1318);
                player.transform.Rotate(78, 0, 0);

                movement.disable_move = false;
                

            }

            //인벤토리 끄기 
            else
            {
                invLight.SetActive(false);
                pick.pick = true;
                player.transform.position = player_posi;
                player.transform.Rotate(-78, 0, 0);
                inven = false;

                movement.disable_move = true;
            }
        }


    }


}