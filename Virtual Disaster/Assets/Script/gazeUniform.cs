﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gazeUniform : MonoBehaviour {


    // private bool gazedAt ;

    private GameObject player;
    pickup forPickup;

    private void Awake()
    {
        player = GameObject.Find("Player");
        
        forPickup = player.GetComponent<pickup>();
        //gazedAt = false;
        
    }

    public void onPointerEnter()
    {
        //gazedAt = true;
        forPickup.ableto_pick = true;
        forPickup.item_name = gameObject.name;

        gameObject.GetComponent<MeshRenderer>().material.shader = Shader.Find("Outlined/Uniform");
        //gameObject.GetComponent<MeshRenderer>().material.shader = Shader.Find("Outlined/Regular");
    }

    public void onPointerExit()
    {
        // gazedAt = false;
        forPickup.ableto_pick = false;
        forPickup.item_name = null;

        gameObject.GetComponent<MeshRenderer>().material.shader = Shader.Find("Standard");
    }
}
