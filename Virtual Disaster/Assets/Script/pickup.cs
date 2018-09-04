using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour
{
    public GameObject EventSystem;
    inventory invScript;

    public GameObject UI_System;
    UIManager uimanage;

    public string item_name; //이름 확인
    public bool ableto_pick; //물건이 gazed at 되어있늨가

    public bool pick; //주울때와 버릴때 비교
    public Vector3 player_place;

    public Sprite[] numbers = new Sprite[8];

    //엔딩 필요 물건들

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

    //페이크 물건들
    private GameObject Apple;
    private GameObject Banana;
    private GameObject Blueprints;
    private GameObject Calculator;
    private GameObject Chem_Mol;
    private GameObject Chemi_Prop_1;
    private GameObject Chemi_Prop_2;
    private GameObject Cuttingboard;
    private GameObject Globe;
    private GameObject Keyboard;
    private GameObject Milk;
    private GameObject Mouse;
    private GameObject Notebook;
    private GameObject Paper;
    private GameObject Pencil;
    private GameObject Soda;
    private GameObject Toilet_Brush;


    private GameObject[] ob_list = null;


    //물건들 개수

    public Image Bottle_1_num;
    public Image Bottle_2_num;
    public Image Bottle_3_num;
    public Image Medkit_num;
    public Image Candy_Bar_1_num;
    public Image Candy_Bar_2_num;
    public Image Candy_Bar_3_num;
    public Image Towel_num;
    public Image Can_1_num;
    public Image Can_2_num;
    public Image Can_3_num;
    public Image Clothes_num;
    public Image Cereal_1_num;
    public Image Cereal_2_num;
    public Image Cup_num;
    public Image Flashlight_num;
    public Image Knife_num;
    public Image Toiletpaper_num;
    public Image Bed_sheets_num;
    public Image Lighter_num;
    public Image Instant_1_num;
    public Image Instant_2_num;
    public Image Spoon_num;
    public Image Plate_num;

    public Image Apple_num;
    public Image Banana_num;
    public Image Blueprints_num;
    public Image Calculator_num;
    public Image Chem_Mol_num;
    public Image Chemi_Prop_1_num;
    public Image Chemi_Prop_2_num;
    public Image Cuttingboard_num;
    public Image Globe_num;
    public Image Keyboard_num;
    public Image Milk_num;
    public Image Mouse_num;
    public Image Notebook_num;
    public Image Paper_num;
    public Image Pencil_num;
    public Image Soda_num;
    public Image Toilet_Brush_num;

    private int Bottle_1_num_save=0 ;
    private int Bottle_2_num_save = 0;
    private int Bottle_3_num_save = 0;
    private int Medkit_num_save = 0;
    private int Candy_Bar_1_num_save = 0;
    private int Candy_Bar_2_num_save = 0;
    private int Candy_Bar_3_num_save = 0;
    private int Towel_num_save = 0;
    private int Can_1_num_save = 0;
    private int Can_2_num_save = 0;
    private int Can_3_num_save = 0;
    private int Clothes_num_save = 0;
    private int Cereal_1_num_save = 0;
    private int Cereal_2_num_save = 0;
    private int Cup_num_save = 0;
    private int Flashlight_num_save = 0;
    private int Knife_num_save = 0;
    private int Toiletpaper_num_save = 0;
    private int Bed_sheets_num_save = 0;
    private int Lighter_num_save = 0;
    private int Instant_1_num_save = 0;
    private int Instant_2_num_save = 0;
    private int Spoon_num_save = 0;
    private int Plate_num_save = 0;

    private int Apple_num_save = 0;
    private int Banana_num_save = 0;
    private int Blueprints_num_save = 0;
    private int Calculator_num_save = 0;
    private int Chem_Mol_num_save = 0;
    private int Chemi_Prop_1_num_save = 0;
    private int Chemi_Prop_2_num_save = 0;
    private int Cuttingboard_num_save = 0;
    private int Globe_num_save = 0;
    private int Keyboard_num_save = 0;
    private int Milk_num_save = 0;
    private int Mouse_num_save = 0;
    private int Notebook_num_save = 0;
    private int Paper_num_save = 0;
    private int Pencil_num_save = 0;
    private int Soda_num_save = 0;
    private int Toilet_Brush_num_save = 0;




    private string forname;
    private int count; //물건 개수용
    private int list_num; //물건 배열용

    private void Awake()
    {
        invScript = EventSystem.GetComponent<inventory>();
        pick = true;
        // ableto_pick = false;
        uimanage = UI_System.GetComponent<UIManager>();


    }


    void Update()
    {
        if (ableto_pick)
        {
            //인벤토리 켜지기 전, 주울 때 
            if (pick && invScript.total_weight < 100 && uimanage.evacUI_2.activeInHierarchy == false&& uimanage.evacUI_1.activeInHierarchy == false)
            { 
                if (Input.GetButtonUp("Fire1"))
                {

                    //병 (1)
                    if (string.Compare(item_name.Substring(0,8), "Bottle_1") == 0)
                    {
                        if (invScript.Bottle_1)
                        {
                            if (invScript.Bottle_1.activeInHierarchy == true)
                            {
                                Bottle_1_num_save++;
                                Change_Image(Bottle_1_num_save, Bottle_1_num);
                                Bottle_1_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Bottle_1_num_save++;
                                invScript.Bottle_1.SetActive(true);
                            }
                        }
                        Bottle_1 = GameObject.Find(item_name);
                        Bottle_1.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 10;
                    }

                    //병 (2)
                    else if (string.Compare(item_name.Substring(0, 8), "Bottle_2") == 0)
                    {
                        if (invScript.Bottle_2)
                        {
                            if (invScript.Bottle_2.activeInHierarchy == true)
                            {
                                Bottle_2_num_save++;
                                Change_Image(Bottle_2_num_save, Bottle_2_num);
                                Bottle_2_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Bottle_2_num_save++;
                                invScript.Bottle_2.SetActive(true);
                            }
                        }
                        Bottle_2 = GameObject.Find(item_name);
                        Bottle_2.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 10;
                    }

                    //병 (3)
                    else if (string.Compare(item_name.Substring(0, 8), "Bottle_3") == 0)
                    {
                        if (invScript.Bottle_3)
                        {
                            if (invScript.Bottle_3.activeInHierarchy == true)
                            {
                                Bottle_3_num_save++;
                                Change_Image(Bottle_3_num_save, Bottle_3_num);
                                Bottle_3_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Bottle_3_num_save++;
                                invScript.Bottle_3.SetActive(true);
                            }
                        }
                        Bottle_3 = GameObject.Find(item_name);
                        Bottle_3.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 10;
                    }

                    else if (item_name.Length > 5 && string.Compare(item_name.Substring(0, 6), "Medkit") == 0)
                    {
                        if (invScript.Medkit)
                        {
                            if (invScript.Medkit.activeInHierarchy == true)
                            {
                                Medkit_num_save++;
                                Change_Image(Medkit_num_save, Medkit_num);
                                Medkit_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Medkit_num_save++;
                                invScript.Medkit.SetActive(true);
                            }
                        }
                        Medkit = GameObject.Find(item_name);
                        Medkit.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 20;
                    }


                    //choco (1)

                    else if (string.Compare(item_name.Substring(0, 11), "Candy_Bar_1") == 0)
                    {
                        if (invScript.Candy_Bar_1)
                        {
                            if (invScript.Candy_Bar_1.activeInHierarchy == true)
                            {
                                Candy_Bar_1_num_save++;
                                Change_Image(Candy_Bar_1_num_save, Candy_Bar_1_num);
                                Candy_Bar_1_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Candy_Bar_1_num_save++;
                                invScript.Candy_Bar_1.SetActive(true);
                            }
                        }
                        Candy_Bar_1 = GameObject.Find(item_name);
                        Candy_Bar_1.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }

                    else if (string.Compare(item_name.Substring(0, 11), "Candy_Bar_2") == 0)
                    {
                        if (invScript.Candy_Bar_2)
                        {
                            if (invScript.Candy_Bar_2.activeInHierarchy == true)
                            {
                                Candy_Bar_2_num_save++;
                                Change_Image(Candy_Bar_2_num_save, Candy_Bar_2_num);
                                Candy_Bar_2_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Candy_Bar_2_num_save++;
                                invScript.Candy_Bar_2.SetActive(true);
                            }
                        }
                        Candy_Bar_2 = GameObject.Find(item_name);
                        Candy_Bar_2.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }

                    else if (string.Compare(item_name.Substring(0, 11), "Candy_Bar_3") == 0)
                    {
                        if (invScript.Candy_Bar_3)
                        {
                            if (invScript.Candy_Bar_3.activeInHierarchy == true)
                            {
                                Candy_Bar_3_num_save++;
                                Change_Image(Candy_Bar_3_num_save, Candy_Bar_3_num);
                                Candy_Bar_3_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Candy_Bar_3_num_save++;
                                invScript.Candy_Bar_3.SetActive(true);
                            }
                        }
                        Candy_Bar_3 = GameObject.Find(item_name);
                        Candy_Bar_3.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }

                    else if (string.Compare(item_name.Substring(0, 5), "Towel") == 0)
                    {
                        if (invScript.Towel)
                        {
                            if (invScript.Towel.activeInHierarchy == true)
                            {
                                Towel_num_save++;
                                Change_Image(Towel_num_save, Towel_num);
                                Towel_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Towel_num_save++;
                                invScript.Towel.SetActive(true);
                            }
                        }
                        Towel = GameObject.Find(item_name);
                        Towel.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 3;
                    }

                    else if (string.Compare(item_name.Substring(0, 5), "Can_1") == 0)
                    {
                        if (invScript.Can_1)
                        {
                            if (invScript.Can_1.activeInHierarchy == true)
                            {
                                Can_1_num_save++;
                                Change_Image(Can_1_num_save, Can_1_num);
                                Can_1_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Can_1_num_save++;
                                invScript.Can_1.SetActive(true);
                            }
                        }
                        Can_1 = GameObject.Find(item_name);
                        Can_1.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }
                    else if (string.Compare(item_name.Substring(0, 5), "Can_2") == 0)
                    {
                        if (invScript.Can_2)
                        {
                            if (invScript.Can_2.activeInHierarchy == true)
                            {
                                Can_2_num_save++;
                                Change_Image(Can_2_num_save, Can_2_num);
                                Can_2_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Can_2_num_save++;
                                invScript.Can_2.SetActive(true);
                            }
                        }
                        Can_2 = GameObject.Find(item_name);
                        Can_2.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }
                    else if (string.Compare(item_name.Substring(0, 5), "Can_3") == 0)
                    {
                        if (invScript.Can_3)
                        {
                            if (invScript.Can_3.activeInHierarchy == true)
                            {
                                Can_3_num_save++;
                                Change_Image(Can_3_num_save, Can_3_num);
                                Can_3_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Can_3_num_save++;
                                invScript.Can_3.SetActive(true);
                            }
                        }
                        Can_3 = GameObject.Find(item_name);
                        Can_3.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }
                    else if (string.Compare(item_name.Substring(0, 7), "Clothes") == 0)
                    {
                        if (invScript.Clothes)
                        {
                            if (invScript.Clothes.activeInHierarchy == true)
                            {
                                Clothes_num_save++;
                                Change_Image(Clothes_num_save, Clothes_num);
                                Clothes_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Clothes_num_save++;
                                invScript.Clothes.SetActive(true);
                            }
                        }
                        Clothes = GameObject.Find(item_name);
                        Clothes.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }
                    else if (string.Compare(item_name.Substring(0, 8), "Cereal_1") == 0)
                    {
                        if (invScript.Cereal_1)
                        {
                            if (invScript.Cereal_1.activeInHierarchy == true)
                            {
                                Cereal_1_num_save++;
                                Change_Image(Cereal_1_num_save, Cereal_1_num);
                                Cereal_1_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Cereal_1_num_save++;
                                invScript.Cereal_1.SetActive(true);
                            }
                        }
                        Cereal_1 = GameObject.Find(item_name);
                        Cereal_1.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }
                    else if (string.Compare(item_name.Substring(0, 8), "Cereal_2") == 0)
                    {
                        if (invScript.Cereal_2)
                        {
                            if (invScript.Cereal_2.activeInHierarchy == true)
                            {
                                Cereal_2_num_save++;
                                Change_Image(Cereal_2_num_save, Cereal_2_num);
                                Cereal_2_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Cereal_2_num_save++;
                                invScript.Cereal_2.SetActive(true);
                            }
                        }
                        Cereal_2 = GameObject.Find(item_name);
                        Cereal_2.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }
                    else if (string.Compare(item_name.Substring(0, 3), "Cup") == 0)
                    {
                        if (invScript.Cup)
                        {
                            if (invScript.Cup.activeInHierarchy == true)
                            {
                                Cup_num_save++;
                                Change_Image(Cup_num_save, Cup_num);
                                Cup_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Cup_num_save++;
                                invScript.Cup.SetActive(true);
                            }
                        }
                        Cup = GameObject.Find(item_name);
                        Cup.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 1;
                    }
                    else if (string.Compare(item_name.Substring(0, 10), "Flashlight") == 0)
                    {
                        if (invScript.Flashlight)
                        {
                            if (invScript.Flashlight.activeInHierarchy == true)
                            {
                                Flashlight_num_save++;
                                Change_Image(Flashlight_num_save, Flashlight_num);
                                Flashlight_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Flashlight_num_save++;
                                invScript.Flashlight.SetActive(true);
                            }
                        }
                        Flashlight = GameObject.Find(item_name);
                        Flashlight.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }
                    else if (string.Compare(item_name.Substring(0, 5), "Knife") == 0)
                    {
                        if (invScript.Knife)
                        {
                            if (invScript.Knife.activeInHierarchy == true)
                            {
                                Knife_num_save++;
                                Change_Image(Knife_num_save, Knife_num);
                                Knife_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Knife_num_save++;
                                invScript.Knife.SetActive(true);
                            }
                        }
                        Knife = GameObject.Find(item_name);
                        Knife.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 3;
                    }
                    else if (string.Compare(item_name.Substring(0, 11), "Toiletpaper") == 0)
                    {
                        if (invScript.Toiletpaper)
                        {
                            if (invScript.Toiletpaper.activeInHierarchy == true)
                            {
                                Toiletpaper_num_save++;
                                Change_Image(Toiletpaper_num_save, Toiletpaper_num);
                                Toiletpaper_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Toiletpaper_num_save++;
                                invScript.Toiletpaper.SetActive(true);
                            }
                        }
                        Toiletpaper = GameObject.Find(item_name);
                        Toiletpaper.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 1;
                    }
                    else if (string.Compare(item_name.Substring(0, 10), "Bed_sheets") == 0)
                    {
                        if (invScript.Bed_sheets)
                        {
                            if (invScript.Bed_sheets.activeInHierarchy == true)
                            {
                                Bed_sheets_num_save++;
                                Change_Image(Bed_sheets_num_save, Bed_sheets_num);
                                Bed_sheets_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Bed_sheets_num_save++;
                                invScript.Bed_sheets.SetActive(true);
                            }
                        }
                        Bed_sheets = GameObject.Find(item_name);
                        Bed_sheets.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 10;
                    }
                    else if (string.Compare(item_name.Substring(0, 7), "Lighter") == 0)
                    {
                        if (invScript.Lighter)
                        {
                            if (invScript.Lighter.activeInHierarchy == true)
                            {
                                Lighter_num_save++;
                                Change_Image(Lighter_num_save, Lighter_num);
                                Lighter_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Lighter_num_save++;
                                invScript.Lighter.SetActive(true);
                            }
                        }
                        Lighter = GameObject.Find(item_name);
                        Lighter.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 1;
                    }
                    else if (string.Compare(item_name.Substring(0, 9), "Instant_1") == 0)
                    {
                        if (invScript.Instant_1)
                        {
                            if (invScript.Instant_1.activeInHierarchy == true)
                            {
                                Instant_1_num_save++;
                                Change_Image(Instant_1_num_save, Instant_1_num);
                                Instant_1_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Instant_1_num_save++;
                                invScript.Instant_1.SetActive(true);
                            }
                        }
                        Instant_1 = GameObject.Find(item_name);
                        Instant_1.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }
                    else if (string.Compare(item_name.Substring(0, 9), "Instant_2") == 0)
                    {
                        if (invScript.Instant_2)
                        {
                            if (invScript.Instant_2.activeInHierarchy == true)
                            {
                                Instant_2_num_save++;
                                Change_Image(Instant_2_num_save, Instant_2_num);
                                Instant_2_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Instant_2_num_save++;
                                invScript.Instant_2.SetActive(true);
                            }
                        }
                        Instant_2 = GameObject.Find(item_name);
                        Instant_2.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }
                    else if (string.Compare(item_name.Substring(0, 5), "Spoon") == 0)
                    {
                        if (invScript.Spoon)
                        {
                            if (invScript.Spoon.activeInHierarchy == true)
                            {
                                Spoon_num_save++;
                                Change_Image(Spoon_num_save, Spoon_num);
                                Spoon_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Spoon_num_save++;
                                invScript.Spoon.SetActive(true);
                            }
                        }
                        Spoon = GameObject.Find(item_name);
                        Spoon.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 3;
                    }
                    else if (string.Compare(item_name.Substring(0, 5), "Plate") == 0)
                    {
                        if (invScript.Plate)
                        {
                            if (invScript.Plate.activeInHierarchy == true)
                            {
                                Plate_num_save++;
                                Change_Image(Plate_num_save, Plate_num);
                                Plate_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Plate_num_save++;
                                invScript.Plate.SetActive(true);
                            }
                        }
                        Plate = GameObject.Find(item_name);
                        Plate.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 1;
                    }

                    /////////////////////////fake 물건들
                    else if (string.Compare(item_name.Substring(0, 5), "Apple") == 0)
                    {
                        if (invScript.Apple)
                        {
                            if (invScript.Apple.activeInHierarchy == true)
                            {
                                Apple_num_save++;
                                Change_Image(Apple_num_save, Apple_num);
                                Apple_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Apple_num_save++;
                                invScript.Apple.SetActive(true);
                            }
                        }
                        Apple = GameObject.Find(item_name);
                        Apple.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 3;
                    }

                    else if (string.Compare(item_name.Substring(0, 6), "Banana") == 0)
                    {
                        if (invScript.Banana)
                        {
                            if (invScript.Banana.activeInHierarchy == true)
                            {
                                Banana_num_save++;
                                Change_Image(Banana_num_save, Banana_num);
                                Banana_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Banana_num_save++;
                                invScript.Banana.SetActive(true);
                            }
                        }
                        Banana = GameObject.Find(item_name);
                        Banana.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 3;
                    }

                    else if (string.Compare(item_name.Substring(0, 10), "Blueprints") == 0)
                    {
                        if (invScript.Blueprints)
                        {
                            if (invScript.Blueprints.activeInHierarchy == true)
                            {
                                Blueprints_num_save++;
                                Change_Image(Blueprints_num_save, Blueprints_num);
                                Blueprints_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Blueprints_num_save++;
                                invScript.Blueprints.SetActive(true);
                            }
                        }
                        Blueprints = GameObject.Find(item_name);
                        Blueprints.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 1;
                    }

                    else if (string.Compare(item_name.Substring(0, 10), "Calculator") == 0)
                    {
                        if (invScript.Calculator)
                        {
                            if (invScript.Calculator.activeInHierarchy == true)
                            {
                                Calculator_num_save++;
                                Change_Image(Calculator_num_save, Calculator_num);
                                Calculator_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Calculator_num_save++;
                                invScript.Calculator.SetActive(true);
                            }
                        }
                        Calculator = GameObject.Find(item_name);
                        Calculator.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 3;
                    }

                    else if (string.Compare(item_name.Substring(0, 8), "Chem_Mol") == 0)
                    {
                        if (invScript.Chem_Mol)
                        {
                            if (invScript.Chem_Mol.activeInHierarchy == true)
                            {
                                Chem_Mol_num_save++;
                                Change_Image(Chem_Mol_num_save, Chem_Mol_num);
                                Chem_Mol_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Chem_Mol_num_save++;
                                invScript.Chem_Mol.SetActive(true);
                            }
                        }
                        Chem_Mol = GameObject.Find(item_name);
                        Chem_Mol.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 3;
                    }

                    else if (string.Compare(item_name.Substring(0, 12), "Chemi_Prop_1") == 0)
                    {
                        if (invScript.Chemi_Prop_1)
                        {
                            if (invScript.Chemi_Prop_1.activeInHierarchy == true)
                            {
                                Chemi_Prop_1_num_save++;
                                Change_Image(Chemi_Prop_1_num_save, Chemi_Prop_1_num);
                                Chemi_Prop_1_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Chemi_Prop_1_num_save++;
                                invScript.Chemi_Prop_1.SetActive(true);
                            }
                        }
                        Chemi_Prop_1 = GameObject.Find(item_name);
                        Chemi_Prop_1.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 3;
                    }

                    else if (string.Compare(item_name.Substring(0, 12), "Chemi_Prop_2") == 0)
                    {
                        if (invScript.Chemi_Prop_2)
                        {
                            if (invScript.Chemi_Prop_2.activeInHierarchy == true)
                            {
                                Chemi_Prop_2_num_save++;
                                Change_Image(Chemi_Prop_2_num_save, Chemi_Prop_2_num);
                                Chemi_Prop_2_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Chemi_Prop_2_num_save++;
                                invScript.Chemi_Prop_2.SetActive(true);
                            }
                        }
                        Chemi_Prop_2 = GameObject.Find(item_name);
                        Chemi_Prop_2.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 3;
                    }

                    else if (string.Compare(item_name.Substring(0, 12), "Cuttingboard") == 0)
                    {
                        if (invScript.Cuttingboard)
                        {
                            if (invScript.Cuttingboard.activeInHierarchy == true)
                            {
                                Cuttingboard_num_save++;
                                Change_Image(Cuttingboard_num_save, Cuttingboard_num);
                                Cuttingboard_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Cuttingboard_num_save++;
                                invScript.Cuttingboard.SetActive(true);
                            }
                        }
                        Cuttingboard = GameObject.Find(item_name);
                        Cuttingboard.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 10;
                    }

                    else if (string.Compare(item_name.Substring(0, 5), "Globe") == 0)
                    {
                        if (invScript.Globe)
                        {
                            if (invScript.Globe.activeInHierarchy == true)
                            {
                                Globe_num_save++;
                                Change_Image(Globe_num_save, Globe_num);
                                Globe_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Globe_num_save++;
                                invScript.Globe.SetActive(true);
                            }
                        }
                        Globe = GameObject.Find(item_name);
                        Globe.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 20;
                    }

                    else if (string.Compare(item_name.Substring(0, 8), "Keyboard") == 0)
                    {
                        if (invScript.Keyboard)
                        {
                            if (invScript.Keyboard.activeInHierarchy == true)
                            {
                                Keyboard_num_save++;
                                Change_Image(Keyboard_num_save, Keyboard_num);
                                Keyboard_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Keyboard_num_save++;
                                invScript.Keyboard.SetActive(true);
                            }
                        }
                        Keyboard = GameObject.Find(item_name);
                        Keyboard.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }

                    else if (string.Compare(item_name.Substring(0, 4), "Milk") == 0)
                    {
                        if (invScript.Milk)
                        {
                            if (invScript.Milk.activeInHierarchy == true)
                            {
                                Milk_num_save++;
                                Change_Image(Milk_num_save, Milk_num);
                                Milk_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Milk_num_save++;
                                invScript.Milk.SetActive(true);
                            }
                        }
                        Milk = GameObject.Find(item_name);
                        Milk.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 10;
                    }

                    else if (string.Compare(item_name.Substring(0, 5), "Mouse") == 0)
                    {
                        if (invScript.Mouse)
                        {
                            if (invScript.Mouse.activeInHierarchy == true)
                            {
                                Mouse_num_save++;
                                Change_Image(Mouse_num_save, Mouse_num);
                                Mouse_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Mouse_num_save++;
                                invScript.Mouse.SetActive(true);
                            }
                        }
                        Mouse = GameObject.Find(item_name);
                        Mouse.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 3;
                    }

                    else if (string.Compare(item_name.Substring(0, 8), "Notebook") == 0)
                    {
                        if (invScript.Notebook)
                        {
                            if (invScript.Notebook.activeInHierarchy == true)
                            {
                                Notebook_num_save++;
                                Change_Image(Notebook_num_save, Notebook_num);
                                Notebook_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Notebook_num_save++;
                                invScript.Notebook.SetActive(true);
                            }
                        }
                        Notebook = GameObject.Find(item_name);
                        Notebook.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 15;
                    }

                    else if (string.Compare(item_name.Substring(0, 5), "Paper") == 0)
                    {
                        if (invScript.Paper)
                        {
                            if (invScript.Paper.activeInHierarchy == true)
                            {
                                Paper_num_save++;
                                Change_Image(Paper_num_save, Paper_num);
                                Paper_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Paper_num_save++;
                                invScript.Paper.SetActive(true);
                            }
                        }
                        Paper = GameObject.Find(item_name);
                        Paper.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 1;
                    }

                    else if (string.Compare(item_name.Substring(0, 6), "Pencil") == 0)
                    {
                        if (invScript.Pencil)
                        {
                            if (invScript.Pencil.activeInHierarchy == true)
                            {
                                Pencil_num_save++;
                                Change_Image(Pencil_num_save, Pencil_num);
                                Pencil_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Pencil_num_save++;
                                invScript.Pencil.SetActive(true);
                            }
                        }
                        Pencil = GameObject.Find(item_name);
                        Pencil.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 1;
                    }

                    else if (string.Compare(item_name.Substring(0, 4), "Soda") == 0)
                    {
                        if (invScript.Soda)
                        {
                            if (invScript.Soda.activeInHierarchy == true)
                            {
                                Soda_num_save++;
                                Change_Image(Soda_num_save, Soda_num);
                                Soda_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Soda_num_save++;
                                invScript.Soda.SetActive(true);
                            }
                        }
                        Soda = GameObject.Find(item_name);
                        Soda.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 5;
                    }

                    else if (string.Compare(item_name.Substring(0, 12), "Toilet_Brush") == 0)
                    {
                        if (invScript.Toilet_Brush)
                        {
                            if (invScript.Toilet_Brush.activeInHierarchy == true)
                            {
                                Toilet_Brush_num_save++;
                                Change_Image(Toilet_Brush_num_save, Toilet_Brush_num);
                                Toilet_Brush_num.gameObject.SetActive(true);
                            }
                            else
                            {
                                Toilet_Brush_num_save++;
                                invScript.Toilet_Brush.SetActive(true);
                            }
                        }
                        Toilet_Brush = GameObject.Find(item_name);
                        Toilet_Brush.transform.position = new Vector3(987, 647, -1317);
                        invScript.total_weight += 10;
                    }


                }
            }

            //인벤토리 켜진 상태, 즉 버릴 때
            else if (!pick && invScript.total_weight >0)
            {

                if (Input.GetButtonUp("Fire1"))
                {

                    //병 (1)
                    if (string.Compare(item_name.Substring(7), "Bottle_1") == 0)
                    {
                        if (Bottle_1_num_save == 1)
                        {
                            Bottle_1_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Bottle_1_num_save--;
                            //if (Bottle_1_num_save == 1)
                            //    Bottle_1_num.gameObject.SetActive(false);
                            Change_Image(Bottle_1_num_save, Bottle_1_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Bottle_1");
                        Trash_thing(ob_list);


                        invScript.total_weight -= 10;
                    }


                    //병 (2)
                    else if (string.Compare(item_name.Substring(7), "Bottle_2") == 0)
                    {
                        if (Bottle_2_num_save == 1)
                        {
                            Bottle_2_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Bottle_2_num_save--;
                            Change_Image(Bottle_2_num_save, Bottle_2_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Bottle_2");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 10;
                    }

                    //병 (3)
                    else if (string.Compare(item_name.Substring(7), "Bottle_3") == 0)
                    {
                        if (Bottle_3_num_save == 1)
                        {
                            Bottle_3_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Bottle_3_num_save--;
                            Change_Image(Bottle_3_num_save, Bottle_3_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Bottle_3");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 10;
                    }

                    else if (string.Compare(item_name.Substring(7), "Medkit") == 0)
                    {
                        if (Medkit_num_save == 1)
                        {
                            Medkit_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Medkit_num_save--;
                            Change_Image(Medkit_num_save, Medkit_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Medkit");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 20;
                    }


                    //choco (1)

                    else if (string.Compare(item_name.Substring(7), "Candy_Bar_1") == 0)
                    {
                        if (Candy_Bar_1_num_save == 1)
                        {
                            Candy_Bar_1_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Candy_Bar_1_num_save--;
                            Change_Image(Candy_Bar_1_num_save, Candy_Bar_1_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Candy_Bar_1");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }

                    else if (string.Compare(item_name.Substring(7), "Candy_Bar_2") == 0)
                    {
                        if (Candy_Bar_2_num_save == 1)
                        {
                            Candy_Bar_2_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Candy_Bar_2_num_save--;
                            Change_Image(Candy_Bar_2_num_save, Candy_Bar_2_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Candy_Bar_2");
                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }

                    else if (string.Compare(item_name.Substring(7), "Candy_Bar_3") == 0)
                    {
                        if (Candy_Bar_3_num_save == 1)
                        {
                            Candy_Bar_3_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Candy_Bar_3_num_save--;
                            Change_Image(Candy_Bar_3_num_save, Candy_Bar_3_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Candy_Bar_3");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }

                    else if (string.Compare(item_name.Substring(7), "Towel") == 0)
                    {
                        if (Towel_num_save == 1)
                        {
                            Towel_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Towel_num_save--;
                            Change_Image(Towel_num_save, Towel_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Towel");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 3;
                    }

                    else if (string.Compare(item_name.Substring(7), "Can_1") == 0)
                    {
                        if (Can_1_num_save == 1)
                        {
                            Can_1_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Can_1_num_save--;
                            Change_Image(Can_1_num_save, Can_1_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Can_1");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }

                    else if (string.Compare(item_name.Substring(7), "Can_2") == 0)
                    {
                        if (Can_2_num_save == 1)
                        {
                            Can_2_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Can_2_num_save--;
                            Change_Image(Can_2_num_save, Can_2_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Can_2");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }


                    else if (string.Compare(item_name.Substring(7), "Can_3") == 0)
                    {
                        if (Can_3_num_save == 1)
                        {
                            Can_3_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Can_3_num_save--;
                            Change_Image(Can_3_num_save, Can_3_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Can_3");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }


                    else if (string.Compare(item_name.Substring(7), "Clothes") == 0)
                    {
                        if (Clothes_num_save == 1)
                        {
                            Clothes_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Clothes_num_save--;
                            Change_Image(Clothes_num_save, Clothes_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Clothes");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }


                    else if (string.Compare(item_name.Substring(7), "Cereal_1") == 0)
                    {
                        if (Cereal_1_num_save == 1)
                        {
                            Cereal_1_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Cereal_1_num_save--;
                            Change_Image(Cereal_1_num_save, Cereal_1_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Cereal_1");
                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }


                    else if (string.Compare(item_name.Substring(7), "Cereal_2") == 0)
                    {
                        if (Cereal_2_num_save == 1)
                        {
                            Cereal_2_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Cereal_2_num_save--;
                            Change_Image(Cereal_2_num_save, Cereal_2_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Cereal_2");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }


                    else if (string.Compare(item_name.Substring(7), "Cup") == 0)
                    {
                        if (Cup_num_save == 1)
                        {
                            Cup_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Cup_num_save--;
                            Change_Image(Cup_num_save, Cup_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Cup");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 1;
                    }


                    else if (string.Compare(item_name.Substring(7), "Flashlight") == 0)
                    {
                        if (Flashlight_num_save == 1)
                        {
                            Flashlight_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Flashlight_num_save--;
                            Change_Image(Flashlight_num_save, Flashlight_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Flashlight");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }


                    else if (string.Compare(item_name.Substring(7), "Knife") == 0)
                    {
                        if (Knife_num_save == 1)
                        {
                            Knife_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Knife_num_save--;
                            Change_Image(Knife_num_save, Knife_num);
                        }
                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Knife");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 3;
                    }


                    else if (string.Compare(item_name.Substring(7), "Toiletpaper") == 0)
                    {
                        if (Toiletpaper_num_save == 1)
                        {
                            Toiletpaper_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Toiletpaper_num_save--;
                            Change_Image(Toiletpaper_num_save, Toiletpaper_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Toiletpaper");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 1;
                    }


                    else if (string.Compare(item_name.Substring(7), "Bed_sheets") == 0)
                    {
                        if (Bed_sheets_num_save == 1)
                        {
                            Bed_sheets_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Bed_sheets_num_save--;
                            Change_Image(Bed_sheets_num_save, Bed_sheets_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Bed_sheets");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 10;
                    }


                    else if (string.Compare(item_name.Substring(7), "Lighter") == 0)
                    {
                        if (Lighter_num_save == 1)
                        {
                            Lighter_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Lighter_num_save--;
                            Change_Image(Lighter_num_save, Lighter_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Lighter");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 1;
                    }


                    else if (string.Compare(item_name.Substring(7), "Instant_1") == 0)
                    {
                        if (Instant_1_num_save == 1)
                        {
                            Instant_1_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Instant_1_num_save--;
                            Change_Image(Instant_1_num_save, Instant_1_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Instant_1");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }


                    else if (string.Compare(item_name.Substring(7), "Instant_2") == 0)
                    {
                        if (Instant_2_num_save == 1)
                        {
                            Instant_2_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Instant_2_num_save--;
                            Change_Image(Instant_2_num_save, Instant_2_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Instant_2");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }


                    else if (string.Compare(item_name.Substring(7), "Spoon") == 0)
                    {
                        if (Spoon_num_save == 1)
                        {
                            Spoon_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Spoon_num_save--;
                            Change_Image(Spoon_num_save, Spoon_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Spoon");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 3;
                    }


                    else if (string.Compare(item_name.Substring(7), "Plate") == 0)
                    {
                        if (Plate_num_save == 1)
                        {
                            Plate_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Plate_num_save--;
                            Change_Image(Plate_num_save, Plate_num);
                        }
                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Plate");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 1;
                    }

                    //////////////////////페이크 물건
                    else if (string.Compare(item_name.Substring(7), "Apple") == 0)
                    {
                        if (Apple_num_save == 1)
                        {
                            {
                                Apple_num_save--;
                                GameObject fordestroy = GameObject.Find(item_name);
                                fordestroy.SetActive(false);
                            }
                        }
                        else
                        {
                            Apple_num_save--;
                            Change_Image(Apple_num_save, Apple_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Apple");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 3;
                    }

                    else if (string.Compare(item_name.Substring(7), "Banana") == 0)
                    {
                        if (Banana_num_save == 1)
                        {
                            Banana_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Banana_num_save--;
                            Change_Image(Banana_num_save, Banana_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Banana");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 3;
                    }

                    else if (string.Compare(item_name.Substring(7), "Blueprints") == 0)
                    {
                        if (Blueprints_num_save == 1)
                        {
                            Blueprints_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Blueprints_num_save--;
                            Change_Image(Blueprints_num_save, Blueprints_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Blueprints");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 1;
                    }

                    else if (string.Compare(item_name.Substring(7), "Calculator") == 0)
                    {
                        if (Calculator_num_save == 1)
                        {
                            Calculator_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Calculator_num_save--;
                            Change_Image(Calculator_num_save, Calculator_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Calculator");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 3;
                    }

                    else if (string.Compare(item_name.Substring(7), "Chem_Mol") == 0)
                    {
                        if (Chem_Mol_num_save == 1)
                        {
                            Chem_Mol_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Chem_Mol_num_save--;
                            Change_Image(Chem_Mol_num_save, Chem_Mol_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Chem_Mol");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 3;
                    }

                    else if (string.Compare(item_name.Substring(7), "Chemi_Prop_1") == 0)
                    {
                        if (Chemi_Prop_1_num_save == 1)
                        {
                            Chemi_Prop_1_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Chemi_Prop_1_num_save--;
                            Change_Image(Chemi_Prop_1_num_save, Chemi_Prop_1_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Chemi_Prop_1");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 3;
                    }

                    else if (string.Compare(item_name.Substring(7), "Chemi_Prop_2") == 0)
                    {
                        if (Chemi_Prop_2_num_save == 1)
                        {
                            Chemi_Prop_2_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Chemi_Prop_2_num_save--;
                            Change_Image(Chemi_Prop_2_num_save, Chemi_Prop_2_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Chemi_Prop_2");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 3;
                    }

                    else if (string.Compare(item_name.Substring(7), "Cuttingboard") == 0)
                    {
                        if( Cuttingboard_num_save == 1)
                        {
                            Cuttingboard_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Cuttingboard_num_save--;
                            Change_Image(Cuttingboard_num_save, Cuttingboard_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Cuttingboard");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 10;
                    }

                    else if (string.Compare(item_name.Substring(7), "Globe") == 0)
                    {
                        if (Globe_num_save == 1)
                        {
                            Globe_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Globe_num_save--;
                            Change_Image(Globe_num_save, Globe_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Globe");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 20;
                    }

                    else if (string.Compare(item_name.Substring(7), "Keyboard") == 0)
                    {
                        if (Keyboard_num_save == 1)
                        {
                            Keyboard_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Keyboard_num_save--;
                            Change_Image(Keyboard_num_save, Keyboard_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Keyboard");

                        Trash_thing(ob_list);
                        invScript.total_weight -=5;
                    }

                    else if (string.Compare(item_name.Substring(7), "Milk") == 0)
                    {
                        if (Milk_num_save == 1)
                        {
                            Milk_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Milk_num_save--;
                            Change_Image(Milk_num_save, Milk_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Milk");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 10;
                    }

                    else if (string.Compare(item_name.Substring(7), "Mouse") == 0)
                    {
                        if (Mouse_num_save == 1)
                        {
                            Mouse_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Mouse_num_save--;
                            Change_Image(Mouse_num_save, Mouse_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Mouse");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 3;
                    }


                    else if (string.Compare(item_name.Substring(7), "Notebook") == 0)
                    {
                        if (Notebook_num_save == 1)
                        {
                            Notebook_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Notebook_num_save--;
                            Change_Image(Notebook_num_save, Notebook_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Notebook");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 15;
                    }

                    else if (string.Compare(item_name.Substring(7), "Paper") == 0)
                    {
                        if (Paper_num_save == 1)
                        {
                            Paper_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Paper_num_save--;
                            Change_Image(Paper_num_save, Paper_num);
                        }


                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Paper");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 1;
                    }

                    else if (string.Compare(item_name.Substring(7), "Pencil") == 0)
                    {
                        if (Pencil_num_save == 1)
                        {
                            Pencil_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Pencil_num_save--;
                            Change_Image(Pencil_num_save, Pencil_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Pencil");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 1;
                    }

                    else if (string.Compare(item_name.Substring(7), "Soda") == 0)
                    {
                        if (Soda_num_save == 1)
                        {
                            Soda_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Soda_num_save--;
                            Change_Image(Soda_num_save, Soda_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Soda");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 5;
                    }

                    else if (string.Compare(item_name.Substring(7), "Toilet_Brush") == 0)
                    {
                        if (Toilet_Brush_num_save == 1)
                        {
                            Toilet_Brush_num_save--;
                            GameObject fordestroy = GameObject.Find(item_name);
                            fordestroy.SetActive(false);
                        }
                        else
                        {
                            Toilet_Brush_num_save--;
                            Change_Image(Toilet_Brush_num_save, Toilet_Brush_num);
                        }

                        list_num = 0;
                        ob_list = GameObject.FindGameObjectsWithTag("Toilet_Brush");

                        Trash_thing(ob_list);
                        invScript.total_weight -= 10;
                    }


                }

            }
        }


    }

    //개수 sprite 바꿔주는 함수
    void Change_Image(int num, Image img)
    {

        if (num == 2)
            img.sprite = numbers[0];

        else if (num == 3)
            img.sprite = numbers[1];
        else if (num == 4)
            img.sprite = numbers[2];
        else if (num == 5)
            img.sprite = numbers[3];
        else if (num == 6)
            img.sprite = numbers[4];
        else if (num == 7)
            img.sprite = numbers[5];
        else if (num == 8)
            img.sprite = numbers[6];
        else if (num == 9)
            img.sprite = numbers[7];
        else if (num == 10)
            img.sprite = numbers[8];
        else if (num == 11)
            img.sprite = numbers[9];
        else if (num == 12)
            img.sprite = numbers[10];
        else if (num == 13)
            img.sprite = numbers[11];
        else if (num == 14)
            img.sprite = numbers[12];
        else if (num == 15)
            img.sprite = numbers[13];
        else if (num ==16)
            img.sprite = numbers[14];
        else if (num == 17)
            img.sprite = numbers[15];
        else if (num == 18)
            img.sprite = numbers[16];
        else if (num == 19)
            img.sprite = numbers[17];
        else if (num == 20)
            img.sprite = numbers[18];
        else if (num == 21)
            img.sprite = numbers[19];
        else if (num == 22)
            img.sprite = numbers[20];
        else if (num == 23)
            img.sprite = numbers[21];
        else if (num == 24)
            img.sprite = numbers[22];
        else if (num == 25)
            img.sprite = numbers[23];
        else
            img.gameObject.SetActive(false);

    }


    //버릴때 알맞은 물건 찾아주는 함수
    void Trash_thing(GameObject[] ob_list)
    {

        for (; ; )
        {
            if (ob_list.Length == 0)
                break;
            else if (ob_list[list_num].transform.position.x < 1000 && 970 < ob_list[list_num].transform.position.x
                && ob_list[list_num].transform.position.y < 650 && 640 < ob_list[list_num].transform.position.y
                && ob_list[list_num].transform.position.z < -1310 && -1320 < ob_list[list_num].transform.position.z)
                break;
            else
                list_num++;
        }

        ob_list[list_num].transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
        ob_list[list_num].SetActive(true);
    }

    //현경: 엔딩용 물건 갯수 받아오는 퍼블릭 함수

    public int GetBottle()
    {
        return Bottle_1_num_save + Bottle_2_num_save + Bottle_3_num_save;
    }

    public int GetMed()
    {
        return Medkit_num_save;
    }

    public int GetFood()
    {
        return Candy_Bar_1_num_save + Candy_Bar_2_num_save + Candy_Bar_3_num_save + Can_1_num_save + Can_2_num_save + Can_3_num_save + Cereal_1_num_save + Cereal_2_num_save + Instant_1_num_save + Instant_2_num_save;
    }

    public int GetTowel()
    {
        return Towel_num_save;
    }

    public int GetTpaper()
    {
        return Toiletpaper_num_save;
    }

    public int GetCutter()
    {
        return Knife_num_save;
    }
    
    public int GetFlash()
    {
        return Flashlight_num_save;
    }

    public int GetBlanket()
    {
        return Bed_sheets_num_save;
    }

    public int GetLighter()
    {
        return Lighter_num_save;
    }

    public int GetClothes()
    {
        return Clothes_num_save;
    }

    public int GetCup()
    {
        return Cup_num_save;
    }

    public int GetPlate()
    {
        return Plate_num_save;
    }

    public int GetSpoon()
    {
        return Spoon_num_save;
    }
}
