using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gazeRegular : MonoBehaviour {
    private GameObject player;
    pickup forPickup;

    int x; //material array 길이 저장 

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

        //gameObject.GetComponent<MeshRenderer>().material.shader = Shader.Find("Outlined/Uniform");
        x = gameObject.GetComponent<MeshRenderer>().materials.Length;

        for (int i = 0; i < x; i++)
        {
            gameObject.GetComponent<MeshRenderer>().materials[i].shader = Shader.Find("Outlined/Regular");
        }

    }

    public void onPointerExit()
    {
        // gazedAt = false;
        forPickup.ableto_pick = false;
        forPickup.item_name = null;

        //gameObject.GetComponent<MeshRenderer>().material.shader = Shader.Find("Standard");
       
        for (int i = 0; i < x; i++)
        {
            gameObject.GetComponent<MeshRenderer>().materials[i].shader = Shader.Find("Standard");
        }
    }
}
