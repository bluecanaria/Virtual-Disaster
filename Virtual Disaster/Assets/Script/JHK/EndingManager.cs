using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingManager : MonoBehaviour {

    public GameObject EndingWin;
    public GameObject[] EndingResult = new GameObject[24];
    public bool[] UnlockedEnd = new bool[24];

    // 시간 계산 타이머
    public static float time;

    // 대피 점수용 시간 계산 타이머
    public static float timeforScore2;

    // 엔딩 스코어
    private int Score_1;
    private int Score_2;
    private int Score_3;

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

    // 인벤토리 물건 Active 여부 체크를 위한 물건 받아오기
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
    void Start()
    {
        time = 180f;
        timeforScore2 = 0f;

        Score_1 = 0;
        Score_2 = 0;
        Score_3 = 0;

        //엔딩 조건을 따지기 위한 논리 변수 초기화
        for (int i = 0; i < 24; i++)
            UnlockedEnd[i] = false;

    }

    private void Update()
    {
        if (time != 0)
        {
            time -= Time.deltaTime;
            if (time <= 0)
            {
                time = 0;
                GotoEnding();
            }
        }

        if(player.transform.position.x < -30.5f && player.transform.position.z < 28)
        {
            Score_1 = 100;
            GotoEnding();
        }

        if (timeforScore2 != 100f)
        {
            if(player.transform.position.z < 29.3)
            {
                timeforScore2 += Time.deltaTime;
            }

            if (timeforScore2 >= 100f)
            {
                timeforScore2 = 100f;
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SaveEnding();
    }

    void CountScore()
    {
        int Score_3_1 = 0;
        int Score_3_2 = 0;
        int Score_3_3 = 0;

        Score_2 = 100 - (int)timeforScore2;

        //if(Bottle_1
    }

    void GotoEnding()
    {
        EventSys.GetComponent<inventory>().enabled = false;
        EndingWin.SetActive(true);

        //인벤토리로 이동
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

    void SaveEnding()
    {
        if (UnlockedEnd[0] == true)
            PlayerPrefs.SetInt("End1", 1);
        if (UnlockedEnd[1] == true)
            PlayerPrefs.SetInt("End2", 1);
        if (UnlockedEnd[2] == true)
            PlayerPrefs.SetInt("End3", 1);
        if (UnlockedEnd[3] == true)
            PlayerPrefs.SetInt("End4", 1);
        if (UnlockedEnd[4] == true)
            PlayerPrefs.SetInt("End5", 1);
        if (UnlockedEnd[5] == true)
            PlayerPrefs.SetInt("End6", 1);
        if (UnlockedEnd[6] == true)
            PlayerPrefs.SetInt("End7", 1);
        if (UnlockedEnd[7] == true)
            PlayerPrefs.SetInt("End8", 1);
        if (UnlockedEnd[8] == true)
            PlayerPrefs.SetInt("End9", 1);
        if (UnlockedEnd[9] == true)
            PlayerPrefs.SetInt("End10", 1);
        if (UnlockedEnd[10] == true)
            PlayerPrefs.SetInt("End11", 1);
        if (UnlockedEnd[11] == true)
            PlayerPrefs.SetInt("End12", 1);
        if (UnlockedEnd[12] == true)
            PlayerPrefs.SetInt("End13", 1);
        if (UnlockedEnd[13] == true)
            PlayerPrefs.SetInt("End14", 1);
        if (UnlockedEnd[14] == true)
            PlayerPrefs.SetInt("End15", 1);
        if (UnlockedEnd[15] == true)
            PlayerPrefs.SetInt("End16", 1);
        if (UnlockedEnd[16] == true)
            PlayerPrefs.SetInt("End17", 1);
        if (UnlockedEnd[17] == true)
            PlayerPrefs.SetInt("End18", 1);
        if (UnlockedEnd[18] == true)
            PlayerPrefs.SetInt("End19", 1);
        if (UnlockedEnd[19] == true)
            PlayerPrefs.SetInt("End20", 1);
        if (UnlockedEnd[20] == true)
            PlayerPrefs.SetInt("End21", 1);
        if (UnlockedEnd[21] == true)
            PlayerPrefs.SetInt("End22", 1);
        if (UnlockedEnd[22] == true)
            PlayerPrefs.SetInt("End23", 1);
        if (UnlockedEnd[23] == true)
            PlayerPrefs.SetInt("End24", 1);
    }

}
