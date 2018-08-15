using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    public GameObject EventSystem;
    inventory invScript;

    public string item_name; //이름 확인
    public bool ableto_pick; //물건이 gazed at 되어있늨가

    public bool pick; //주울때와 버릴때 비교
    public Vector3 player_place;


    //묽런들

    private GameObject Bottle_1;
    private GameObject Bottle_2;
    private GameObject Bottle_3;
    private GameObject Medkit;
    private GameObject Candy_Bar_1;
    private GameObject Candy_Bar_2;
    private GameObject Candy_Bar_3;
    private GameObject Towel;
    private GameObject Can_1;
    private GameObject Can_2;
    private GameObject Can_3;
    private GameObject Clothes;
    private GameObject Cereal_1;
    private GameObject Cereal_2;
    private GameObject Cup;
    private GameObject Flashlight;
    private GameObject Knife;
    private GameObject Toiletpaper;
    private GameObject Bed_sheets;
    private GameObject Lighter;
    private GameObject Instant_1;
    private GameObject Instant_2;
    private GameObject Spoon;
    private GameObject Plate;

    private void Awake()
    {
        invScript = EventSystem.GetComponent<inventory>();
        pick = true;
       // ableto_pick = false;
    }


    void Update()
    {
        if (ableto_pick)
        {
            //인벤토리 켜지기 전, 주울 때 
            if (pick)
            { 
                if (Input.GetKeyDown(KeyCode.E))
                {

                    //병 (1)
                    if (string.Compare(item_name, "Bottle_1") == 0)
                    {
                        if (invScript.Bottle_1)
                        { 
                            invScript.Bottle_1.SetActive(true);
                        }
                        Bottle_1 = GameObject.Find(item_name);
                        Bottle_1.SetActive(false);
                    }

                    //병 (2)
                    else if (string.Compare(item_name, "Bottle_2") == 0)
                    {
                        if (invScript.Bottle_2)
                        {
                            invScript.Bottle_2.SetActive(true);
                        }
                        Bottle_2 = GameObject.Find(item_name);
                        Bottle_2.SetActive(false);
                    }

                    //병 (3)
                    else if (string.Compare(item_name, "Bottle_3") == 0)
                    {
                        if (invScript.Bottle_3)
                        {
                            invScript.Bottle_3.SetActive(true);
                        }
                        Bottle_3 = GameObject.Find(item_name);
                        Bottle_3.SetActive(false);
                    }

                    else if (string.Compare(item_name, "Medkit") == 0)
                    {
                        if (invScript.Medkit)
                        {
                            invScript.Medkit.SetActive(true);
                        }
                        Medkit = GameObject.Find(item_name);
                        Medkit.SetActive(false);
                    }


                    //choco (1)

                    else if (string.Compare(item_name, "Candy_Bar_1") == 0)
                    {
                        if (invScript.Candy_Bar_1)
                        {
                            invScript.Candy_Bar_1.SetActive(true);
                        }
                        Candy_Bar_1 = GameObject.Find(item_name);
                        Candy_Bar_1.SetActive(false);
                    }

                    else if (string.Compare(item_name, "Candy_Bar_2") == 0)
                    {
                        if (invScript.Candy_Bar_2)
                        {
                            invScript.Candy_Bar_2.SetActive(true);
                        }
                        Candy_Bar_2 = GameObject.Find(item_name);
                        Candy_Bar_2.SetActive(false);
                    }

                    else if (string.Compare(item_name, "Candy_Bar_3") == 0)
                    {
                        if (invScript.Candy_Bar_3)
                        {
                            invScript.Candy_Bar_3.SetActive(true);
                        }
                        Candy_Bar_3 = GameObject.Find(item_name);
                        Candy_Bar_3.SetActive(false);
                    }

                    else if (string.Compare(item_name, "Towel") == 0)
                    {
                        if (invScript.Towel)
                        {
                            invScript.Towel.SetActive(true);
                        }
                        Towel = GameObject.Find(item_name);
                        Towel.SetActive(false);
                    }

                    else if (string.Compare(item_name, "Can_1") == 0)
                    {
                        if (invScript.Can_1)
                        {
                            invScript.Can_1.SetActive(true);
                        }
                        Can_1 = GameObject.Find(item_name);
                        Can_1.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Can_2") == 0)
                    {
                        if (invScript.Can_2)
                        {
                            invScript.Can_2.SetActive(true);
                        }
                        Can_2 = GameObject.Find(item_name);
                        Can_2.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Can_3") == 0)
                    {
                        if (invScript.Can_3)
                        {
                            invScript.Can_3.SetActive(true);
                        }
                        Can_3 = GameObject.Find(item_name);
                        Can_3.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Clothes") == 0)
                    {
                        if (invScript.Clothes)
                        {
                            invScript.Clothes.SetActive(true);
                        }
                        Clothes = GameObject.Find(item_name);
                        Clothes.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Cereal_1") == 0)
                    {
                        if (invScript.Cereal_1)
                        {
                            invScript.Cereal_1.SetActive(true);
                        }
                        Cereal_1 = GameObject.Find(item_name);
                        Cereal_1.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Cereal_2") == 0)
                    {
                        if (invScript.Cereal_2)
                        {
                            invScript.Cereal_2.SetActive(true);
                        }
                        Cereal_2 = GameObject.Find(item_name);
                        Cereal_2.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Cup") == 0)
                    {
                        if (invScript.Cup)
                        {
                            invScript.Cup.SetActive(true);
                        }
                        Cup = GameObject.Find(item_name);
                        Cup.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Flashlight") == 0)
                    {
                        if (invScript.Flashlight)
                        {
                            invScript.Flashlight.SetActive(true);
                        }
                        Flashlight = GameObject.Find(item_name);
                        Flashlight.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Knife") == 0)
                    {
                        if (invScript.Knife)
                        {
                            invScript.Knife.SetActive(true);
                        }
                        Knife = GameObject.Find(item_name);
                        Knife.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Toiletpaper") == 0)
                    {
                        if (invScript.Toiletpaper)
                        {
                            invScript.Toiletpaper.SetActive(true);
                        }
                        Toiletpaper = GameObject.Find(item_name);
                        Toiletpaper.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Bed_sheets") == 0)
                    {
                        if (invScript.Bed_sheets)
                        {
                            invScript.Bed_sheets.SetActive(true);
                        }
                        Bed_sheets = GameObject.Find(item_name);
                        Bed_sheets.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Lighter") == 0)
                    {
                        if (invScript.Lighter)
                        {
                            invScript.Lighter.SetActive(true);
                        }
                        Lighter = GameObject.Find(item_name);
                        Lighter.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Instant_1") == 0)
                    {
                        if (invScript.Instant_1)
                        {
                            invScript.Instant_1.SetActive(true);
                        }
                        Instant_1 = GameObject.Find(item_name);
                        Instant_1.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Instant_2") == 0)
                    {
                        if (invScript.Instant_2)
                        {
                            invScript.Instant_2.SetActive(true);
                        }
                        Instant_2 = GameObject.Find(item_name);
                        Instant_2.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Spoon") == 0)
                    {
                        if (invScript.Spoon)
                        {
                            invScript.Spoon.SetActive(true);
                        }
                        Spoon = GameObject.Find(item_name);
                        Spoon.SetActive(false);
                    }
                    else if (string.Compare(item_name, "Plate") == 0)
                    {
                        if (invScript.Plate)
                        {
                            invScript.Plate.SetActive(true);
                        }
                        Plate = GameObject.Find(item_name);
                        Plate.SetActive(false);
                    }


                }
            }

            //인벤토리 켜진 상태, 즉 버릴 때
            else if(!pick)
            {
                //Debug.Log("trash1111");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    //Debug.Log("trash");

                    GameObject fordestroy = GameObject.Find(item_name);
                    fordestroy.SetActive(false);

                    Debug.Log(item_name.Substring(7));

                    //병 (1)
                    if (string.Compare(item_name.Substring(7), "Bottle_1") == 0)
                    {
                        Bottle_1.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Bottle_1.SetActive(true);
                    }

                    //병 (2)
                    else if (string.Compare(item_name.Substring(7), "Bottle_2") == 0)
                    {
                        Bottle_2.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Bottle_2.SetActive(true);
                    }

                    //병 (3)
                    else if (string.Compare(item_name.Substring(7), "Bottle_3") == 0)
                    {
                        Bottle_3.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Bottle_3.SetActive(true);
                    }

                    else if (string.Compare(item_name.Substring(7), "Medkit") == 0)
                    {
                        Medkit.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Medkit.SetActive(true);
                    }


                    //choco (1)

                    else if (string.Compare(item_name.Substring(7), "Candy_Bar_1") == 0)
                    {
                        Candy_Bar_1.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Candy_Bar_1.SetActive(true);
                    }

                    else if (string.Compare(item_name.Substring(7), "Candy_Bar_2") == 0)
                    {
                        Candy_Bar_2.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Candy_Bar_2.SetActive(true);
                    }

                    else if (string.Compare(item_name.Substring(7), "Candy_Bar_3") == 0)
                    {
                        Candy_Bar_3.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Candy_Bar_3.SetActive(true);
                    }

                    else if (string.Compare(item_name.Substring(7), "Towel") == 0)
                    {
                        Towel.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Towel.SetActive(true);
                    }

                    else if (string.Compare(item_name.Substring(7), "Can_1") == 0)
                    {
                        Can_1.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Can_1.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Can_2") == 0)
                    {
                        Can_2.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Can_2.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Can_3") == 0)
                    {
                        Can_3.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Can_3.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Clothes") == 0)
                    {
                        Clothes.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Clothes.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Cereal_1") == 0)
                    {
                        Cereal_1.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Cereal_1.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Cereal_2") == 0)
                    {
                        Cereal_2.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Cereal_2.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Cup") == 0)
                    {
                        Cup.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Cup.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Flashlight") == 0)
                    {
                        Flashlight.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Flashlight.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Knife") == 0)
                    {
                        Knife.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Knife.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Toiletpaper") == 0)
                    {
                        Toiletpaper.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Toiletpaper.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Bed_sheets") == 0)
                    {
                        Bed_sheets.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Bed_sheets.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Lighter") == 0)
                    {
                        Lighter.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Lighter.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Instant_1") == 0)
                    {
                        Instant_1.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Instant_1.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Instant_2") == 0)
                    {
                        Instant_2.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Instant_2.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Spoon") == 0)
                    {
                        Spoon.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Spoon.SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Plate") == 0)
                    {
                        Plate.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Plate.SetActive(true);
                    }


                }

            }
        }


    }

      



}
