using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{

    public GameObject invLight;
    public GameObject player;
    move movement;
    pickup pick;

    private bool inven;
    private Vector3 player_posi;
    private Rigidbody rb;


    ///물ㄹ건들 
    public GameObject Bottle_1;
    public GameObject Bottle_2;
    public GameObject Bottle_3;
    public GameObject Medkit;
    public GameObject Candy_Bar_1;
    public GameObject Candy_Bar_2;
    public GameObject Candy_Bar_3;
    public GameObject Towel;
    public GameObject Can_1;
    public GameObject Can_2;
    public GameObject Can_3;
    public GameObject Clothes;
    public GameObject Cereal_1;
    public GameObject Cereal_2;
    public GameObject Cup;
    public GameObject Flashlight;
    public GameObject Knife;
    public GameObject Toiletpaper;
    public GameObject Bed_sheets;
    public GameObject Lighter;
    public GameObject Instant_1;
    public GameObject Instant_2;
    public GameObject Spoon;
    public GameObject Plate;

    // Use this for initialization
    private void Awake()
    {
        inven = false;
        invLight.SetActive(false);
        movement = player.GetComponent<move>();
        pick = player.GetComponent<pickup>();
        rb = player.GetComponent<Rigidbody>();


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
                //var rotationVector = transform.rotation.eulerAngles;

                rb.useGravity = false;
                player.transform.rotation = Quaternion.Euler(78,0,0);

                player_posi = player.transform.position;
                pick.player_place = player_posi;
                player.transform.position = new Vector3(960, 650, -1318);



                
                movement.disable_move = false;
                

            }

            //인벤토리 끄기 
            else
            {
                invLight.SetActive(false);
                pick.pick = true;

                player.transform.rotation = Quaternion.Euler(0,0,0);

                rb.useGravity = true;
                player.transform.position = player_posi;



                inven = false;

                movement.disable_move = true;

            }
        }


    }


}