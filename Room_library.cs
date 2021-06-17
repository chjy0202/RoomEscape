using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room_library : MonoBehaviour {

    public GameObject alpkeypad;    //알파벳키패드

    public GameObject setans;
    public GameObject drawer;

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
                //기존방 물체
                if (hit.collider.gameObject == setans)
                {
                    alpkeypad.SetActive(true);
                }

                //서랍애니메이션실행
				if (hit.collider.gameObject.name == "Drawer2") {
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



                //알파벳키패트에대한 이벤트
                if (hit.collider.gameObject.name == "keypad_a")
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
