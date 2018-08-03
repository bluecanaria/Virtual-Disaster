using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interaction : MonoBehaviour
{


   // private bool gazedAt ;
 
    public GameObject player;
    pickup forPickup;


    // Use this for initialization
    void Start()
    {
       
    }

    private void Awake()
    {
        forPickup = player.GetComponent<pickup>();
        //gazedAt = false;
    }

    // Update is called once per frame
    private void Update()
    {
       
       
    }


    public void onPointerEnter()
    {
        
        //gazedAt = true;
        forPickup.ableto_pick = true;
        forPickup.item_name = gameObject.name;
        //gameObject.GetComponent<MeshRenderer>().material.shader = Shader.Find("Outlined/Uniform");
        gameObject.GetComponent<MeshRenderer>().material.shader = Shader.Find("Outlined/Regular");
    }

    public void onPointerExit()
    {
       // gazedAt = false;
        forPickup.ableto_pick = false;
        forPickup.item_name = null;
         gameObject.GetComponent<MeshRenderer>().material.shader = Shader.Find("Standard");
    }
}