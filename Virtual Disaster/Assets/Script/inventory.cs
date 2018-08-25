using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{

    public GameObject invLight;
    public GameObject player;
    public GameObject GvrReticle;
    move movement;
    pickup pick;
    GvrReticlePointer point;

    private bool inven;
    private Vector3 player_posi;
    private Rigidbody rb;

    public int total_weight;


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

    //페이크 물건들
    public GameObject Apple;
    public GameObject Banana;
    public GameObject Blueprints;
    public GameObject Calculator;
    public GameObject Chem_Mol;
    public GameObject Chemi_Prop_1;
    public GameObject Chemi_Prop_2;
    public GameObject Cuttingboard;
    public GameObject Globe;
    public GameObject Keyboard;
    public GameObject Milk;
    public GameObject Mouse;
    public GameObject Notebook;
    public GameObject Paper;
    public GameObject Pencil;
    public GameObject Soda;
    public GameObject Toilet_Brush;

    // Use this for initialization
    private void Awake()
    {
        inven = false;
        invLight.SetActive(false);
        movement = player.GetComponent<move>();
        pick = player.GetComponent<pickup>();
        rb = player.GetComponent<Rigidbody>();
        point = GvrReticle.GetComponent<GvrReticlePointer>();

        total_weight = 0;


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

                point.maxReticleDistance = 6;



                
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

                point.maxReticleDistance = 3;

                inven = false;

                movement.disable_move = true;

            }
        }


    }


}