using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_hospital : MonoBehaviour {

    public GameObject numberkeypad; //숫자키패드
    public GameObject dirkeypad;    //방향키패드

    public GameObject setans1;
    public GameObject setans2;

    public GameObject drawer;

    public GameObject button0;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject buttonClose;
    public GameObject buttonbackspace;

    private SteamVR_TrackedObject trackedObj;

    private SteamVR_Controller.Device controller
    {
        get { return SteamVR_Controller.Input((int)trackedObj.index); }
    }

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }


    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(trackedObj.transform.position, transform.forward, out hit, 100))
        {
            if (controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
            {
                //키패드발생
                if (hit.collider.gameObject==setans1)
                {
                    numberkeypad.SetActive(true);
                }
                if (hit.collider.gameObject==setans2)
                {
                    dirkeypad.SetActive(true);
                }

                //애니메이션??
                if (hit.collider.gameObject.name == "Drawer2")
                {
                    drawer.SendMessage("PlayAnim2");
                }
                if (hit.collider.gameObject.name == "Drawer3")
                {
                    drawer.SendMessage("PlayAnim3");
                }
                if (hit.collider.gameObject.name == "Drawer5")
                {
                    drawer.SendMessage("PlayAnim5");
                }
                if (hit.collider.gameObject.name == "Drawer7")
                {
                    drawer.SendMessage("PlayAnim7");
                }
                if (hit.collider.gameObject.name == "Drawer8")
                {
                    drawer.SendMessage("PlayAnim8");
                }


                //숫자키패드
                if (hit.collider.gameObject == button0)
                {
                    numberkeypad.SendMessage("Number0");
                }
                if (hit.collider.gameObject == button1)
                {
                    numberkeypad.SendMessage("Number1");
                }
                if (hit.collider.gameObject == button2)
                {
                    numberkeypad.SendMessage("Number2");
                }
                if (hit.collider.gameObject == button3)
                {
                    numberkeypad.SendMessage("Number3");
                }
                if (hit.collider.gameObject == button4)
                {
                    numberkeypad.SendMessage("Number4");
                }
                if (hit.collider.gameObject == button5)
                {
                    numberkeypad.SendMessage("Number5");
                }
                if (hit.collider.gameObject == button6)
                {
                    numberkeypad.SendMessage("Number6");
                }
                if (hit.collider.gameObject == button7)
                {
                    numberkeypad.SendMessage("Number7");
                }
                if (hit.collider.gameObject == button8)
                {
                    numberkeypad.SendMessage("Number8");
                }
                if (hit.collider.gameObject == button9)
                {
                    numberkeypad.SendMessage("Number9");
                }
                if (hit.collider.gameObject == buttonClose)
                {
                    numberkeypad.SendMessage("Pwdclose");
                }
                if (hit.collider.gameObject == buttonbackspace)
                {
                    numberkeypad.SendMessage("Backspace");
                }

                //방향키에대한 이벤트
                if (hit.collider.gameObject.name == "key_up")
                {
                    dirkeypad.SendMessage("InputUp");
                }
                if (hit.collider.gameObject.name == "key_down")
                {
                    dirkeypad.SendMessage("InputDown");
                }
                if (hit.collider.gameObject.name == "key_left")
                {
                    dirkeypad.SendMessage("InputLeft");
                }
                if (hit.collider.gameObject.name == "key_right")
                {
                    dirkeypad.SendMessage("InputRight");
                }
                if (hit.collider.gameObject.name == "key_close")
                {
                    dirkeypad.SendMessage("InputClose");
                }
                if (hit.collider.gameObject.name == "key_backspace")
                {
                    dirkeypad.SendMessage("InputBackspace");
                }

            }
        }
    }
}
