using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interaction : MonoBehaviour {

    private float gazeTime = 2f; //이 시간동안 바라봐야 이벤트 발생

    private float timer;

    private bool gazedAt;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
		if(gazedAt)//물체를 바라보고 있으면
        {
            timer += Time.deltaTime;
            if(timer>=gazeTime)//응시 시간 이상 바라보면 이벤트 실행
            {
                ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                timer = 0f;
            }
        }
        */
	}
    public void onPointerEnter()
    {
        gazedAt = true;
        gameObject.GetComponent<MeshRenderer>().material.shader=Shader.Find("Outlined/Uniform");
    }
    public void onPointerExit()
    {
        gazedAt = false;
        gameObject.GetComponent<MeshRenderer>().material.shader = Shader.Find("Standard");
    }
}
