using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingManager : MonoBehaviour {

    public GameObject EndingWin;
    public Text Score1Obj;
    public Text Score2Obj;
    public Text Score3Obj;

    public GameObject[] EndingResult = new GameObject[24];

    // 시간 계산 타이머
    public static float time;

    // 대피 점수용 시간 계산 타이머
    public static float timeforScore2;

    // 엔딩 스코어
    private int Score_1;
    private int Score_2;
    private int Score_3;

    private int Score_3_1;
    private int Score_3_2;
    private int Score_3_3;

    // 인벤토리 켜는 용
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

    //private bool inven;
    private Vector3 player_posi;
    private Rigidbody rb;

    public int total_weight;

    public GameObject EventSys;


    //오디오 조절 용
    public GameObject EmerSound;
    public GameObject SirenSound;

    private void Awake()
    {
        inven = false;
        invLight.SetActive(false);
        movement = player.GetComponent<move>();

        //예진//
        crouch = player.GetComponent<Crouch>();
        cubeCamera = player.transform.GetChild(0).gameObject;

        pick = player.GetComponent<pickup>();
        rb = player.GetComponent<Rigidbody>();
        point = GvrReticle.GetComponent<GvrReticlePointer>();

        total_weight = 0;

    }

    // Use this for initialization
    void Start()
    {
        time = 300f;
        timeforScore2 = 0f;

        Score_1 = 0;
        Score_2 = 0;
        Score_3 = 0;

        Score_3_1 = 0;
        Score_3_2 = 0;
        Score_3_3 = 0;

    }

    private void Update()
    {
        if (time != 0)
        {
            time -= Time.deltaTime;

            if (time <= 60f)
            {
                EmerSound.SetActive(true);
            }

            if (time <= 25f)
            {
                SirenSound.SetActive(true);
            }

            if (time <= 0)
            {
                if(player.GetComponent<Crouch>().isCrouched == false)
                {
                    Score_2 -= 30;
                }
                time = 0;
                GotoEnding();
            }
        }

        if(player.transform.position.x < -30.5f && player.transform.position.x > -31.5f && player.transform.position.z < 28)
        {
            Score_1 = 100;
            GotoEnding();
        }

        if (timeforScore2 != 100f)
        {
            if(player.transform.position.z < 29.5f && player.transform.position.x < 17f && player.transform.position.x>-41)
            {
                timeforScore2 += Time.deltaTime;
            }

            if (timeforScore2 >= 100f)
            {
                timeforScore2 = 100f;
            }
        }
    }

    private void CountScore()
    {

        Score_2 = 100 - ((int)timeforScore2);

        if (player.GetComponent<pickup>().GetBottle() >= 3 && player.GetComponent<pickup>().GetFood() >= 2 && player.GetComponent<pickup>().GetMed() >= 1)
        {
            Score_3_1 = 40;
        }

        if (player.GetComponent<pickup>().GetTowel() >= 1) Score_3_2 += 15;
        if (player.GetComponent<pickup>().GetTpaper() >= 1) Score_3_2 += 15;

        Score_3_3 += player.GetComponent<pickup>().GetCutter() * 10;
        Score_3_3 += player.GetComponent<pickup>().GetLighter() * 10;
        Score_3_3 += player.GetComponent<pickup>().GetBlanket() * 6;
        Score_3_3 += player.GetComponent<pickup>().GetFlash() * 6;
        Score_3_3 += player.GetComponent<pickup>().GetCup() * 2;
        Score_3_3 += player.GetComponent<pickup>().GetPlate() * 2;
        Score_3_3 += player.GetComponent<pickup>().GetSpoon() * 2;

        if (Score_3_3 >= 30) Score_3_3 = 30;

        Score_3 = Score_3_1 + Score_3_2 + Score_3_3;

        if (Score_2 > 100) Score_2 = 100;
        if (Score_2 < 0) Score_2 = 0;

        if (Score_3 > 100) Score_3 = 100;

    }

    private void EndingCheck()
    {
        if(Score_1==100 && Score_2<50 && Score_3_1==0)
        {
            PlayerPrefs.SetInt("End1", 1);
            EndingResult[0].SetActive(true);
        }

        if (Score_1 == 100 && Score_2 < 50 && Score_3_1 == 40 && Score_3_2 < 30)
        {
            PlayerPrefs.SetInt("End2", 1);
            EndingResult[1].SetActive(true);
        }

        if (Score_1 == 100 && Score_2 < 50 && Score_3_1 == 40 && Score_3_2 == 30 && Score_3_3<15)
        {
            PlayerPrefs.SetInt("End3", 1);
            EndingResult[2].SetActive(true);
        }

        if (Score_1 == 100 && Score_2 < 50 && Score_3_1 == 40 && Score_3_2 == 30 && Score_3_3 >= 15)
        {
            PlayerPrefs.SetInt("End4", 1);
            EndingResult[3].SetActive(true);
        }

        if (Score_1 == 100 && Score_2 > 50 && Score_3_1 == 0)
        {
            PlayerPrefs.SetInt("End5", 1);
            EndingResult[4].SetActive(true);
        }

        if (Score_1 == 100 && Score_2 > 50 && Score_3_1 == 40 && Score_3_2 < 30)
        {
            PlayerPrefs.SetInt("End6", 1);
            EndingResult[5].SetActive(true);
        }

        if (Score_1 == 100 && Score_2 > 50 && Score_3_1 == 40 && Score_3_2 == 30 && Score_3_3 < 15)
        {
            PlayerPrefs.SetInt("End7", 1);
            EndingResult[6].SetActive(true);
        }

        if (Score_1 == 100 && Score_2 > 50 && Score_3_1 == 40 && Score_3_2 == 30 && Score_3_3 >= 15)
        {
            if(Score_2 != 100 && Score_3 !=100)
            {
                PlayerPrefs.SetInt("End8", 1);
                EndingResult[7].SetActive(true);
            }

            if (Score_2 == 100 && Score_3 != 100)
            {
                PlayerPrefs.SetInt("End8", 1);
                EndingResult[7].SetActive(true);
            }

            if (Score_2 != 100 && Score_3 == 100)
            {
                PlayerPrefs.SetInt("End8", 1);
                EndingResult[7].SetActive(true);
            }
        }

        if(Score_1 == 0 && player.GetComponent<Crouch>().isCrouched == false && Score_2<50)
        {
            if (Score_3_1 == 0 && Score_2 != 0)
            {
                PlayerPrefs.SetInt("End9", 1);
                EndingResult[8].SetActive(true);
            }

            if (Score_3_1 == 40 && Score_3_2 < 30)
            {
                PlayerPrefs.SetInt("End10", 1);
                EndingResult[9].SetActive(true);
            }

            if (Score_3_1 == 40 && Score_3_2 == 30 && Score_3_3 < 15)
            {
                PlayerPrefs.SetInt("End11", 1);
                EndingResult[10].SetActive(true);
            }

            if (Score_3_1 == 40 && Score_3_2 == 30 && Score_3_3 >= 15)
            {
                PlayerPrefs.SetInt("End12", 1);
                EndingResult[11].SetActive(true);
            }
        }

        if (Score_1 == 0 && player.GetComponent<Crouch>().isCrouched == false && Score_2 >= 50)
        {
            if (Score_3_1 == 0)
            {
                PlayerPrefs.SetInt("End13", 1);
                EndingResult[12].SetActive(true);
            }

            if (Score_3_1 == 40 && Score_3_2 < 30)
            {
                PlayerPrefs.SetInt("End13", 1);
                EndingResult[12].SetActive(true);
            }

            if (Score_3_1 == 40 && Score_3_2 == 30 && Score_3_3 < 15)
            {
                PlayerPrefs.SetInt("End13", 1);
                EndingResult[12].SetActive(true);
            }

            if (Score_3_1 == 40 && Score_3_2 == 30 && Score_3_3 >= 15)
            {
                PlayerPrefs.SetInt("End14", 1);
                EndingResult[13].SetActive(true);
            }
        }

        if (Score_1 == 0 && player.GetComponent<Crouch>().isCrouched == true && Score_2 < 50)
        {
            if (Score_3_1 == 0)
            {
                PlayerPrefs.SetInt("End15", 1);
                EndingResult[14].SetActive(true);
            }

            if (Score_3_1 == 40 && Score_3_2 < 30)
            {
                PlayerPrefs.SetInt("End16", 1);
                EndingResult[15].SetActive(true);
            }

            if (Score_3_1 == 40 && Score_3_2 == 30 && Score_3_3 < 15)
            {
                PlayerPrefs.SetInt("End17", 1);
                EndingResult[16].SetActive(true);
            }

            if (Score_3_1 == 40 && Score_3_2 == 30 && Score_3_3 >= 15)
            {
                PlayerPrefs.SetInt("End18", 1);
                EndingResult[17].SetActive(true);
            }
        }

        if (Score_1 == 0 && player.GetComponent<Crouch>().isCrouched == true && Score_2 >= 50)
        {
            if (Score_3_1 == 0)
            {
                PlayerPrefs.SetInt("End19", 1);
                EndingResult[18].SetActive(true);
            }

            if (Score_3_1 == 40 && Score_3_2 < 30)
            {
                PlayerPrefs.SetInt("End20", 1);
                EndingResult[19].SetActive(true);
            }

            if (Score_3_1 == 40 && Score_3_2 == 30 && Score_3_3 < 15)
            {
                PlayerPrefs.SetInt("End21", 1);
                EndingResult[20].SetActive(true);
            }

            if (Score_3_1 == 40 && Score_3_2 == 30 && Score_3_3 >= 15)
            {
                PlayerPrefs.SetInt("End22", 1);
                EndingResult[21].SetActive(true);
            }
        }

        if(Score_1 == 0 && Score_2 == 0 && Score_3 == 0)
        {
            PlayerPrefs.SetInt("End23", 1);
            EndingResult[22].SetActive(true);
        }

        if (Score_1 == 100 && Score_2 == 100 && Score_3 == 100)
        {
            PlayerPrefs.SetInt("End24", 1);
            EndingResult[23].SetActive(true);
        }

    }

    private void GotoEnding()
    {
        EventSys.GetComponent<inventory>().enabled = false;
        player.GetComponent<pickup>().enabled = false;
        EndingWin.SetActive(true);

        CountScore();
        EndingCheck();
        Score1Obj.text = Score_1.ToString();
        Score2Obj.text = Score_2.ToString();
        Score3Obj.text = Score_3.ToString();

        rb.constraints = RigidbodyConstraints.FreezeAll;
        //예진// 초점이 켜져있지않다면 다시 킨다
        if (!point.enabled)
        {
            point.enabled = true;
        }

        invLight.SetActive(true);
        inven = true;
        pick.pick = false;
        //var rotationVector = transform.rotation.eulerAngles;

        rb.useGravity = false;
        player.transform.rotation = Quaternion.Euler(78, 0, 0);

        player_posi = player.transform.position;
        pick.player_place = player_posi;
        player.transform.position = new Vector3(960, 650, -1318);

        point.maxReticleDistance = 6;




        movement.disable_move = false;

    }

}
