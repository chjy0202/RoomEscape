using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Controller : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj; //추적할 오브젝트의 레퍼런스를 선언-> HMD와 컨트롤러 둘 다 의미
    public SteamVR_Controller.Device controller
    {
        get
        {
            return SteamVR_Controller.Input((int)GetComponent<SteamVR_TrackedObject>().index);
        }
    }//CONTROLLER에 쉽게 접근하기 위해 추적한 오브젝트의 인덱스를 사용하여 Controller의 입력으로 전달

void Awake()
{
  trackedObj=GetComponent<SteamVR_TrackedObject>();
}

	void Update () {
    if (controller.GetAxis()!=Vector2.zero)
    {
      Debug.Log(gameObject.name+controller.GetAxis());
    }//touch 패드 위에 올려진 손가락의 위치값을 획득하여 콘솔에 입력

    if (controller.GetHairTriggerDown())
    {
      Debug.Log(gameObject.name+"Trigger Press");
    }//hair trigger 를 눌렀을 때 정보 전달.
    //GetHairTrigger(),GetHairTriggerUp(),GetHairTriggerDown() 로 확인 가능

    if (controller.GetHairTriggerUp())
    {
      Debug.Log(gameObject.name+"Trigger Release");
    }//hairtrigger 누른 상태에서 놓았을 떼 정보전달

    if (controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
    {
      Debug.Log(gameObject.name+"Grip Press");
    }//grip버튼을 눌렀을때 정보전달
    //GetPressDown() 함수가 버튼의 눌러짐을 체크하는 표준함수

    if (controller.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
    {
      Debug.Log(gameObject.name+"Grip Release");
    }//grip 버튼을 누른 상태에서 놓았을 때 그 정보틑 전달
    //GetPressUp() 함수가 버튼의 놓여짐을 체크하는 표준함수
	}
}
