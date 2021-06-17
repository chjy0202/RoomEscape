using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_cafe : MonoBehaviour {

    public GameObject board;

    public GameObject numberkeypad; //숫자키패드
    public GameObject alpkeypad;    //알파벳키패드

	public GameObject treasurebox;

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

    
	void Update () {
        RaycastHit hit;
        if (Physics.Raycast(trackedObj.transform.position, transform.forward, out hit, 100))
        {
            if (controller.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
            {
                //칠판힌트
                if (hit.collider.gameObject == board)
                {
                    numberkeypad.SetActive(true);
                }

				//상자클릭후 최종답안입력
				if (hit.collider.gameObject == treasurebox) {
					alpkeypad.SetActive (true);
				}

                //숫자키패드
                if (hit.collider.gameObject==button0)
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

                //알파벳키패트에대한 이벤트
                if (hit.collider.gameObject.name== "keypad_a")
                {
                    alpkeypad.SendMessage("Input_A");
                }
                if (hit.collider.gameObject.name == "keypad_b")
                {
                    alpkeypad.SendMessage("Input_B");
                }
                if (hit.collider.gameObject.name == "keypad_c")
                {
                    alpkeypad.SendMessage("Input_C");
                }
                if (hit.collider.gameObject.name == "keypad_d")
                {
                    alpkeypad.SendMessage("Input_D");
                }
                if (hit.collider.gameObject.name == "keypad_e")
                {
                    alpkeypad.SendMessage("Input_E");
                }
                if (hit.collider.gameObject.name == "keypad_f")
                {
                    alpkeypad.SendMessage("Input_F");
                }
                if (hit.collider.gameObject.name == "keypad_g")
                {
                    alpkeypad.SendMessage("Input_G");
                }
                if (hit.collider.gameObject.name == "keypad_h")
                {
                    alpkeypad.SendMessage("Input_H");
                }
                if (hit.collider.gameObject.name == "keypad_i")
                {
                    alpkeypad.SendMessage("Input_I");
                }
                if (hit.collider.gameObject.name == "keypad_j")
                {
                    alpkeypad.SendMessage("Input_J");
                }
                if (hit.collider.gameObject.name == "keypad_k")
                {
                    alpkeypad.SendMessage("Input_K");
                }
                if (hit.collider.gameObject.name == "keypad_l")
                {
                    alpkeypad.SendMessage("Input_L");
                }
                if (hit.collider.gameObject.name == "keypad_m")
                {
                    alpkeypad.SendMessage("Input_M");
                }
                if (hit.collider.gameObject.name == "keypad_n")
                {
                    alpkeypad.SendMessage("Input_N");
                }
                if (hit.collider.gameObject.name == "keypad_o")
                {
                    alpkeypad.SendMessage("Input_O");
                }
                if (hit.collider.gameObject.name == "keypad_p")
                {
                    alpkeypad.SendMessage("Input_P");
                }
                if (hit.collider.gameObject.name == "keypad_q")
                {
                    alpkeypad.SendMessage("Input_Q");
                }
                if (hit.collider.gameObject.name == "keypad_r")
                {
                    alpkeypad.SendMessage("Input_R");
                }
                if (hit.collider.gameObject.name == "keypad_s")
                {
                    alpkeypad.SendMessage("Input_S");
                }
                if (hit.collider.gameObject.name == "keypad_t")
                {
                    alpkeypad.SendMessage("Input_T");
                }
                if (hit.collider.gameObject.name == "keypad_u")
                {
                    alpkeypad.SendMessage("Input_U");
                }
                if (hit.collider.gameObject.name == "keypad_v")
                {
                    alpkeypad.SendMessage("Input_V");
                }
                if (hit.collider.gameObject.name == "keypad_w")
                {
                    alpkeypad.SendMessage("Input_W");
                }
                if (hit.collider.gameObject.name == "keypad_x")
                {
                    alpkeypad.SendMessage("Input_X");
                }
                if (hit.collider.gameObject.name == "keypad_y")
                {
                    alpkeypad.SendMessage("Input_Y");
                }
                if (hit.collider.gameObject.name == "keypad_z")
                {
                    alpkeypad.SendMessage("Input_Z");
                }
                if (hit.collider.gameObject.name == "keypad_backspace")
                {
                    alpkeypad.SendMessage("Input_backspace");
                }
                if (hit.collider.gameObject.name == "keypad_enter")
                {
                    alpkeypad.SendMessage("Input_enter");
                }
                if (hit.collider.gameObject.name == "keypad_close")
                {
                    alpkeypad.SendMessage("Input_close");
                }
            }
        }
    }
}
