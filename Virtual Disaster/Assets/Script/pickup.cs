using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    private GameObject[] ob_list = null;


    //물건들 개수

    public Text Bottle_1_num;
    public Text Bottle_2_num;
    public Text Bottle_3_num;
    public Text Medkit_num;
    public Text Candy_Bar_1_num;
    public Text Candy_Bar_2_num;
    public Text Candy_Bar_3_num;
    public Text Towel_num;
    public Text Can_1_num;
    public Text Can_2_num;
    public Text Can_3_num;
    public Text Clothes_num;
    public Text Cereal_1_num;
    public Text Cereal_2_num;
    public Text Cup_num;
    public Text Flashlight_num;
    public Text Knife_num;
    public Text Toiletpaper_num;
    public Text Bed_sheets_num;
    public Text Lighter_num;
    public Text Instant_1_num;
    public Text Instant_2_num;
    public Text Spoon_num;
    public Text Plate_num;


    private string forname;
    private int count; //물건 개수용
    private int list_num; //물건 배열용

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
                    if (string.Compare(item_name.Substring(0,8), "Bottle_1") == 0)
                    {
                        if (invScript.Bottle_1)
                        {
                            if (invScript.Bottle_1.activeInHierarchy == true)
                            {
                                count = int.Parse(Bottle_1_num.text);
                                count++;
                                Bottle_1_num.text = count.ToString();
                                Bottle_1_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Bottle_1.SetActive(true);
                        }
                        Bottle_1 = GameObject.Find(item_name);
                        Bottle_1.transform.position = new Vector3(987, 647, -1317);
                    }

                    //병 (2)
                    else if (string.Compare(item_name.Substring(0,8), "Bottle_2") == 0)
                    {
                        if (invScript.Bottle_2)
                        {
                            if (invScript.Bottle_2.activeInHierarchy == true)
                            {
                                count = int.Parse(Bottle_2_num.text);
                                count++;
                                Bottle_2_num.text = count.ToString();
                                Bottle_2_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Bottle_2.SetActive(true);
                        }
                        Bottle_2 = GameObject.Find(item_name);
                        Bottle_2.transform.position = new Vector3(987, 647, -1317);
                    }

                    //병 (3)
                    else if (string.Compare(item_name.Substring(0, 8), "Bottle_3") == 0)
                    {
                        if (invScript.Bottle_3)
                        {
                            if (invScript.Bottle_3.activeInHierarchy == true)
                            {
                                count = int.Parse(Bottle_3_num.text);
                                count++;
                                Bottle_3_num.text = count.ToString();
                                Bottle_3_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Bottle_3.SetActive(true);
                        }
                        Bottle_3 = GameObject.Find(item_name);
                        Bottle_3.transform.position = new Vector3(987, 647, -1317);
                    }

                    else if (item_name.Length > 5 && string.Compare(item_name.Substring(0,6), "Medkit") == 0)
                    {
                        if (invScript.Medkit)
                        {
                            if (invScript.Medkit.activeInHierarchy == true)
                            {
                                count = int.Parse(Medkit_num.text);
                                count++;
                                Medkit_num.text = count.ToString();
                                Medkit_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Medkit.SetActive(true);
                        }
                        Medkit = GameObject.Find(item_name);
                        Medkit.transform.position = new Vector3(987, 647, -1317);
                    }


                    //choco (1)

                    else if (string.Compare(item_name.Substring(0,11), "Candy_Bar_1") == 0)
                    {
                        if (invScript.Candy_Bar_1)
                        {
                            if (invScript.Candy_Bar_1.activeInHierarchy == true)
                            {
                                count = int.Parse(Candy_Bar_1_num.text);
                                count++;
                                Candy_Bar_1_num.text = count.ToString();
                                Candy_Bar_1_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Candy_Bar_1.SetActive(true);
                        }
                    Candy_Bar_1 = GameObject.Find(item_name);
                    Candy_Bar_1.transform.position = new Vector3(987, 647, -1317);
                }

                    else if (string.Compare(item_name.Substring(0, 11), "Candy_Bar_2") == 0)
                    {
                        if (invScript.Candy_Bar_2)
                        {
                            if (invScript.Candy_Bar_2.activeInHierarchy == true)
                            {
                                count = int.Parse(Candy_Bar_2_num.text);
                                count++;
                                Candy_Bar_2_num.text = count.ToString();
                                Candy_Bar_2_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Candy_Bar_2.SetActive(true);
                        }
                        Candy_Bar_2 = GameObject.Find(item_name);
                        Candy_Bar_2.transform.position = new Vector3(987, 647, -1317);
                    }

                    else if (string.Compare(item_name.Substring(0, 11), "Candy_Bar_3") == 0)
                    {
                        if (invScript.Candy_Bar_3)
                        {
                            if (invScript.Candy_Bar_3.activeInHierarchy == true)
                            {
                                count = int.Parse(Candy_Bar_3_num.text);
                                count++;
                                Candy_Bar_3_num.text = count.ToString();
                                Candy_Bar_3_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Candy_Bar_3.SetActive(true);
                        }
                        Candy_Bar_3 = GameObject.Find(item_name);
                        Candy_Bar_3.transform.position = new Vector3(987, 647, -1317);
                    }

                    else if (string.Compare(item_name.Substring(0, 5), "Towel") == 0)
                    {
                        if (invScript.Towel)
                        {
                            if (invScript.Towel.activeInHierarchy == true)
                            {
                                count = int.Parse(Towel_num.text);
                                count++;
                                Towel_num.text = count.ToString();
                                Towel_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Towel.SetActive(true);
                        }
                        Towel = GameObject.Find(item_name);
                        Towel.transform.position = new Vector3(987, 647, -1317);
                    }

                    else if (string.Compare(item_name.Substring(0, 5), "Can_1") == 0)
                    {
                        if (invScript.Can_1)
                        {
                            if (invScript.Can_1.activeInHierarchy == true)
                            {
                                count = int.Parse(Can_1_num.text);
                                count++;
                                Can_1_num.text = count.ToString();
                                Can_1_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Can_1.SetActive(true);
                        }
                        Can_1 = GameObject.Find(item_name);
                        Can_1.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 5), "Can_2") == 0)
                    {
                        if (invScript.Can_2)
                        {
                            if (invScript.Can_2.activeInHierarchy == true)
                            {
                                count = int.Parse(Can_2_num.text);
                                count++;
                                Can_2_num.text = count.ToString();
                                Can_2_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Can_2.SetActive(true);
                        }
                        Can_2 = GameObject.Find(item_name);
                        Can_2.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 5), "Can_3") == 0)
                    {
                        if (invScript.Can_3)
                        {
                            if (invScript.Can_3.activeInHierarchy == true)
                            {
                                count = int.Parse(Can_3_num.text);
                                count++;
                                Can_3_num.text = count.ToString();
                                Can_3_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Can_3.SetActive(true);
                        }
                        Can_3 = GameObject.Find(item_name);
                        Can_3.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 7), "Clothes") == 0)
                    {
                        if (invScript.Clothes)
                        {
                            if (invScript.Clothes.activeInHierarchy == true)
                            {
                                count = int.Parse(Clothes_num.text);
                                count++;
                                Clothes_num.text = count.ToString();
                                Clothes_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Clothes.SetActive(true);
                        }
                        Clothes = GameObject.Find(item_name);
                        Clothes.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 8), "Cereal_1") == 0)
                    {
                        if (invScript.Cereal_1)
                        {
                            if (invScript.Cereal_1.activeInHierarchy == true)
                            {
                                count = int.Parse(Cereal_1_num.text);
                                count++;
                                Cereal_1_num.text = count.ToString();
                                Cereal_1_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Cereal_1.SetActive(true);
                        }
                        Cereal_1 = GameObject.Find(item_name);
                        Cereal_1.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 8), "Cereal_2") == 0)
                    {
                        if (invScript.Cereal_2)
                        {
                            if (invScript.Cereal_2.activeInHierarchy == true)
                            {
                                count = int.Parse(Cereal_2_num.text);
                                count++;
                                Cereal_2_num.text = count.ToString();
                                Cereal_2_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Cereal_2.SetActive(true);
                        }
                        Cereal_2 = GameObject.Find(item_name);
                        Cereal_2.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 3), "Cup") == 0)
                    {
                        if (invScript.Cup)
                        {
                            if (invScript.Cup.activeInHierarchy == true)
                            {
                                count = int.Parse(Cup_num.text);
                                count++;
                                Cup_num.text = count.ToString();
                                Cup_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Cup.SetActive(true);
                        }
                        Cup = GameObject.Find(item_name);
                        Cup.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 10), "Flashlight") == 0)
                    {
                        if (invScript.Flashlight)
                        {
                            if (invScript.Flashlight.activeInHierarchy == true)
                            {
                                count = int.Parse(Flashlight_num.text);
                                count++;
                                Flashlight_num.text = count.ToString();
                                Flashlight_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Flashlight.SetActive(true);
                        }
                        Flashlight = GameObject.Find(item_name);
                        Flashlight.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 5), "Knife") == 0)
                    {
                        if (invScript.Knife)
                        {
                            if (invScript.Knife.activeInHierarchy == true)
                            {
                                count = int.Parse(Knife_num.text);
                                count++;
                                Knife_num.text = count.ToString();
                                Knife_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Knife.SetActive(true);
                        }
                        Knife = GameObject.Find(item_name);
                        Knife.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 11), "Toiletpaper") == 0)
                    {
                        if (invScript.Toiletpaper)
                        {
                            if (invScript.Toiletpaper.activeInHierarchy == true)
                            {
                                count = int.Parse(Toiletpaper_num.text);
                                count++;
                                Toiletpaper_num.text = count.ToString();
                                Toiletpaper_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Toiletpaper.SetActive(true);
                        }
                        Toiletpaper = GameObject.Find(item_name);
                        Toiletpaper.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 10), "Bed_sheets") == 0)
                    {
                        if (invScript.Bed_sheets)
                        {
                            if (invScript.Bed_sheets.activeInHierarchy == true)
                            {
                                count = int.Parse(Bed_sheets_num.text);
                                count++;
                                Bed_sheets_num.text = count.ToString();
                                Bed_sheets_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Bed_sheets.SetActive(true);
                        }
                        Bed_sheets = GameObject.Find(item_name);
                        Bed_sheets.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 7), "Lighter") == 0)
                    {
                        if (invScript.Lighter)
                        {
                            if (invScript.Lighter.activeInHierarchy == true)
                            {
                                count = int.Parse(Lighter_num.text);
                                count++;
                                Lighter_num.text = count.ToString();
                                Lighter_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Lighter.SetActive(true);
                        }
                        Lighter = GameObject.Find(item_name);
                        Lighter.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 9), "Instant_1") == 0)
                    {
                        if (invScript.Instant_1)
                        {
                            if (invScript.Instant_1.activeInHierarchy == true)
                            {
                                count = int.Parse(Instant_1_num.text);
                                count++;
                                Instant_1_num.text = count.ToString();
                                Instant_1_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Instant_1.SetActive(true);
                        }
                        Instant_1 = GameObject.Find(item_name);
                        Instant_1.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 9), "Instant_2") == 0)
                    {
                        if (invScript.Instant_2)
                        {
                            if (invScript.Instant_2.activeInHierarchy == true)
                            {
                                count = int.Parse(Instant_2_num.text);
                                count++;
                                Instant_2_num.text = count.ToString();
                                Instant_2_num.gameObject.SetActive(true);

                            }
                            else
                                invScript.Instant_2.SetActive(true);
                        }
                        Instant_2 = GameObject.Find(item_name);
                        Instant_2.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 5), "Spoon") == 0)
                    {
                        if (invScript.Spoon)
                        {
                            if (invScript.Spoon.activeInHierarchy == true)
                            {
                                count = int.Parse(Spoon_num.text);
                                count++;
                                Spoon_num.text = count.ToString();
                                Spoon_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Spoon.SetActive(true);
                        }
                        Spoon = GameObject.Find(item_name);
                        Spoon.transform.position = new Vector3(987, 647, -1317);
                    }
                    else if (string.Compare(item_name.Substring(0, 5), "Plate") == 0)
                    {
                        if (invScript.Plate)
                        {
                            if (invScript.Plate.activeInHierarchy == true)
                            {
                                count = int.Parse(Plate_num.text);
                                count++;
                                Plate_num.text = count.ToString();
                                Plate_num.gameObject.SetActive(true);
                            }
                            else
                                invScript.Plate.SetActive(true);
                        }
                        Plate = GameObject.Find(item_name);
                        Plate.transform.position = new Vector3(987, 647, -1317);
                    }


                }
            }

            //인벤토리 켜진 상태, 즉 버릴 때
            else if(!pick)
            {
                
                if (Input.GetKeyDown(KeyCode.E))
                {
                   
                    //병 (1)
                    if (string.Compare(item_name.Substring(7), "Bottle_1") == 0)
                    {
                        count = int.Parse(Bottle_1_num.text);
                        if (count == 1){
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if(count==1)
                                Bottle_1_num.gameObject.SetActive(false);
                            Bottle_1_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Bottle_1");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }

                    //병 (2)
                    else if (string.Compare(item_name.Substring(7), "Bottle_2") == 0)
                    {
                        count = int.Parse(Bottle_2_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Bottle_2_num.gameObject.SetActive(false);
                            Bottle_2_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Bottle_2");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }

                    //병 (3)
                    else if (string.Compare(item_name.Substring(7), "Bottle_3") == 0)
                    {
                        count = int.Parse(Bottle_3_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Bottle_3_num.gameObject.SetActive(false);
                            Bottle_3_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Bottle_3");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }

                    else if (string.Compare(item_name.Substring(7), "Medkit") == 0)
                    {
                        count = int.Parse(Medkit_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Medkit_num.gameObject.SetActive(false);
                            Medkit_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Medkit");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }


                    //choco (1)

                    else if (string.Compare(item_name.Substring(7), "Candy_Bar_1") == 0)
                    {
                        count = int.Parse(Candy_Bar_1_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Candy_Bar_1_num.gameObject.SetActive(false);
                            Candy_Bar_1_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Candy_Bar_1");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }

                    else if (string.Compare(item_name.Substring(7), "Candy_Bar_2") == 0)
                    {
                        count = int.Parse(Candy_Bar_2_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Candy_Bar_2_num.gameObject.SetActive(false);
                            Candy_Bar_2_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Candy_Bar_2");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }

                    else if (string.Compare(item_name.Substring(7), "Candy_Bar_3") == 0)
                    {
                        count = int.Parse(Candy_Bar_3_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Candy_Bar_3_num.gameObject.SetActive(false);
                            Candy_Bar_3_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Candy_Bar_3");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }

                    else if (string.Compare(item_name.Substring(7), "Towel") == 0)
                    {
                        count = int.Parse(Towel_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Towel_num.gameObject.SetActive(false);
                            Towel_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Towel");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }

                    else if (string.Compare(item_name.Substring(7), "Can_1") == 0)
                    {
                        count = int.Parse(Can_1_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Can_1_num.gameObject.SetActive(false);
                            Can_1_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Can_1");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Can_2") == 0)
                    {
                        count = int.Parse(Can_2_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Can_2_num.gameObject.SetActive(false);
                            Can_2_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Can_2");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Can_3") == 0)
                    {
                        count = int.Parse(Can_3_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Can_3_num.gameObject.SetActive(false);
                            Can_3_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Can_3");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Clothes") == 0)
                    {
                        count = int.Parse(Clothes_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Clothes_num.gameObject.SetActive(false);
                            Clothes_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Clothes");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Cereal_1") == 0)
                    {
                        count = int.Parse(Cereal_1_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Cereal_1_num.gameObject.SetActive(false);
                            Cereal_1_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Cereal_1");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Cereal_2") == 0)
                    {
                        count = int.Parse(Cereal_2_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Cereal_2_num.gameObject.SetActive(false);
                            Cereal_2_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Cereal_2");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Cup") == 0)
                    {
                        count = int.Parse(Cup_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Cup_num.gameObject.SetActive(false);
                            Cup_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Cup");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Flashlight") == 0)
                    {
                        count = int.Parse(Flashlight_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Flashlight_num.gameObject.SetActive(false);
                            Flashlight_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Flashlight");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Knife") == 0)
                    {
                        count = int.Parse(Knife_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Knife_num.gameObject.SetActive(false);
                            Knife_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Knife");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Toiletpaper") == 0)
                    {
                        count = int.Parse(Toiletpaper_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Toiletpaper_num.gameObject.SetActive(false);
                            Toiletpaper_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Toiletpaper");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Bed_sheets") == 0)
                    {
                        count = int.Parse(Bed_sheets_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Bed_sheets_num.gameObject.SetActive(false);
                            Bed_sheets_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Bed_sheets");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Lighter") == 0)
                    {
                        count = int.Parse(Lighter_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Lighter_num.gameObject.SetActive(false);
                            Lighter_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Lighter");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Instant_1") == 0)
                    {
                        count = int.Parse(Instant_1_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Instant_1_num.gameObject.SetActive(false);
                            Instant_1_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Instant_1");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Instant_2") == 0)
                    {
                        count = int.Parse(Instant_2_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Instant_2_num.gameObject.SetActive(false);
                            Instant_2_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Instant_2");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Spoon") == 0)
                    {
                        count = int.Parse(Spoon_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Spoon_num.gameObject.SetActive(false);
                            Spoon_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Spoon");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }
                    else if (string.Compare(item_name.Substring(7), "Plate") == 0)
                    {
                        count = int.Parse(Plate_num.text);
                        if (count == 1)
                        {
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            count--;
                            if (count == 1)
                                Plate_num.gameObject.SetActive(false);
                            Plate_num.text = count.ToString();
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Plate");

                        for (; ; )
                        {
                            if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                                break;
                            else if (ob_list.Length == 0)
                                break;
                            else
                                list_num++;
                        }

                        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        ob_list[list_num].SetActive(true);
                    }


                }

            }
        }


    }

      



}
