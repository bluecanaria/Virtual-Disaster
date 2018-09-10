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

    //예진//
    Crouch crouch;
    public bool inven;
    GameObject cubeCamera;
    UIManager uimanager;

    //private bool inven;
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

        //예진//
        crouch = player.GetComponent<Crouch>();
        cubeCamera = player.transform.GetChild(0).gameObject;
        uimanager = GameObject.Find("UI_System").GetComponent<UIManager>();

        pick = player.GetComponent<pickup>();
        rb = player.GetComponent<Rigidbody>();
        point = GvrReticle.GetComponent<GvrReticlePointer>();

        total_weight = 0;


    }

    // Update is called once per frame
    void Update()
    {
        //인벤토리 켜기 
        if (Input.GetButtonUp("Jump")) {


            if (inven == false)
            {
                rb.constraints = RigidbodyConstraints.FreezeAll;
                //예진// 초점이 켜져있지않다면 다시 킨다, UI도 끈다
                uimanager.evacUI_1.SetActive(false);
                uimanager.evacUI_2.SetActive(false);
                if (!point.enabled)
                {
                    point.enabled = true;                    
                }

                invLight.SetActive(true);
                inven = true;
                pick.pick = false;
                //var rotationVector = transform.rotation.eulerAngles;

                rb.useGravity = false;
                player.transform.rotation = Quaternion.Euler(78,0,0);

                player_posi = player.transform.position;
                pick.player_place = player_posi;
                player.transform.position = new Vector3(960, 650, -1318);

                //예진//항상 플레이어의 위치보다 y축으로 0.7높게 카메라가 위치한다
                cubeCamera.transform.localPosition = new Vector3(0,0.7f,0);

                point.maxReticleDistance = 6;



                
                movement.disable_move = false;
                

            }

            //인벤토리 끄기 
            else
            {

                rb.constraints = RigidbodyConstraints.FreezeRotation;
                invLight.SetActive(false);
                pick.pick = true;

                player.transform.rotation = Quaternion.Euler(0, 0, 0);

                rb.useGravity = true;
                //player.transform.position = player_posi;
                //예진//플레이어가 숙인상태가 아니라면 다시 움직여도 된다
                if (!crouch.isCrouched)
                {
                    movement.disable_move = true;
                    player.transform.position = player_posi;
                    if(crouch.tableCollided)//책상과 아직 접해있다면 들어가는 ui를 다시 킨다
                    {
                        uimanager.evacUI_2.SetActive(true);
                    }
                }
                //플레이어가 아직 숙인상태라면 다시 초점을 끈다,ui도 킨다
                else if(crouch.isCrouched)
                {
                    point.enabled = false;
                    //cubeCamera.transform.position = crouch.crouchPos;
                    player.transform.position = player_posi;
                    //예진//플레이어 머리에 달린 카메라도 원래 위치로 돌아가게 한다
                    //Debug.Log(crouch.crouchPos);
                    cubeCamera.transform.position = crouch.crouchPos;
                    uimanager.evacUI_1.SetActive(true);
                    uimanager.evacUI_2.SetActive(false);
                    //player.transform.position = player_posi;

                }

                //invLight.SetActive(false);
                //pick.pick = true;

                //player.transform.rotation = Quaternion.Euler(0,0,0);

                //rb.useGravity = true;
                //player.transform.position = player_posi;
                ////예진//플레이어 머리에 달린 카메라도 원래 위치로 돌아가게 한다
                //cubeCamera.transform.position = crouch.crouchPos;

                point.maxReticleDistance = 3;

                inven = false;


                

            }
        }


    }


}