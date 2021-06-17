using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Keypad_script_4 : MonoBehaviour {

    static string pwd1 = null;
    static string pwd2 = null;
    static string pwd3 = null;
    static string pwd4 = null;

    public GameObject keypad_alp;

    private string inputpwd;
    private string realpwd="CARD";

    public Text txt;

    private void Input_alp_pwd(string temp)
    {
        if (pwd1==null)
        {
            pwd1 = temp;
        }
        else if (pwd2==null)
        {
            pwd2 = temp;
        }
        else if(pwd3==null)
        {
            pwd3 = temp;
        }
        else if (pwd4==null)
        {
            pwd4 = temp;
        }
        inputpwd = pwd1 + pwd2 + pwd3+pwd4;
        txt.text = inputpwd;
		//Debug.Log(inputpwd);
        
    }

    private void ChangeSceneChange()
    {
        SceneManager.LoadScene("test-room3_hospital");
    }

    private void DetCollect()
    {
        if (realpwd==inputpwd)
        {
            Invoke("ChangeSceneChange", 3);
        }
        else
        {
            pwd1 = null;
            pwd2 = null;
            pwd3 = null;
            pwd4 = null;
            txt.text = "Retry";
        }
    }

    private void Backspace()
    {
        if (pwd4 != null) 
        {
            pwd4 = null;
        }
        else if (pwd3 != null)
        {
            pwd3 = null;
        }
        else if (pwd2 != null)
        {
            pwd2 = null;
        }
        else if (pwd1 != null)
        {
            pwd1 = null;
        }
        inputpwd = pwd1 + pwd2 + pwd3 + pwd4;
        txt.text = inputpwd;
    }

    public void Input_backspace()
    {
        Backspace();
    }

    public void Input_enter()
    {
        DetCollect();
    }

    public void Input_close()
    {
        keypad_alp.SetActive(false);
    }

	public void Input_A()
    {
        Input_alp_pwd("A");
    }

    public void Input_B()
    {
        Input_alp_pwd("B");
    }

    public void Input_C()
    {
        Input_alp_pwd("C");
    }

    public void Input_D()
    {   
        Input_alp_pwd("D");
    }

    public void Input_E()
    {
        Input_alp_pwd("E");
    }

    public void Input_F()
    {
        Input_alp_pwd("F");
    }

    public void Input_G()
    {
        Input_alp_pwd("G");
    }

    public void Input_H()
    {
        Input_alp_pwd("H");
    }

    public void Input_I()
    {
        Input_alp_pwd("I");
    }

    public void Input_J()
    {
        Input_alp_pwd("J");
    }

    public void Input_K()
    {
        Input_alp_pwd("K");
    }

    public void Input_L()
    {
        Input_alp_pwd("L");
    }

    public void Input_M()
    {
        Input_alp_pwd("M");
    }

    public void Input_N()
    {
        Input_alp_pwd("N");
    }

    public void Input_O()
    {
        Input_alp_pwd("O");
    }

    public void Input_P()
    {
        Input_alp_pwd("P");
    }

    public void Input_Q()
    {
        Input_alp_pwd("Q");
    }

    public void Input_R()
    {
        Input_alp_pwd("R");
    }

    public void Input_S()
    {
        Input_alp_pwd("S");
    }

    public void Input_T()
    {
        Input_alp_pwd("T");
    }

    public void Input_U()
    {
        Input_alp_pwd("U");
    }

    public void Input_V()
    {
        Input_alp_pwd("V");
    }

    public void Input_W()
    {
        Input_alp_pwd("W");
    }

    public void Input_X()
    {
        Input_alp_pwd("X");
    }

    public void Input_Y()
    {
        Input_alp_pwd("Y");
    }

    public void Input_Z()
    {
        Input_alp_pwd("Z");
    }

}
