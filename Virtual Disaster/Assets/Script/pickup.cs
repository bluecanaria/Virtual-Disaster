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

    private GameObject Bottle_1;
    private GameObject Candy_Bar ;

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

                    //choco

                    else if (string.Compare(item_name, "Candy_Bar") == 0)
                    {
                        if (invScript.Candy_Bar)
                        {
                            invScript.Candy_Bar.SetActive(true);
                        }
                        Candy_Bar = GameObject.Find(item_name);
                        Candy_Bar.SetActive(false);
                    }

                
                }
            }

            //인벤토리 켜진 상태, 즉 버릴 때
            else if(!pick)
            {
                Debug.Log("trash1111");
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Debug.Log("trash");

                    GameObject fordestroy = GameObject.Find(item_name);
                    fordestroy.SetActive(false);

                    Debug.Log(item_name.Substring(7));

                    //병 (1)
                    if (string.Compare(item_name.Substring(7), "Bottle_1") == 0)
                    {
                        Bottle_1.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Bottle_1.SetActive(true);
                    }

                    //choco

                    else if (string.Compare(item_name.Substring(7), "Candy_Bar") == 0)
                    {
                        Candy_Bar.transform.position = new Vector3(player_place.x, player_place.y, player_place.z + 1);
                        Candy_Bar.SetActive(true);
                    }


                }

            }
        }


    }

      



}
