using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keynum_2 : MonoBehaviour {

    public Text pwdtxt;
    public GameObject keypad_number;
    public GameObject anscanvas;

    public GameObject hex_before;
    public GameObject hex_after;

	public GameObject door_before;
	public GameObject door_after;

    private static int A=10;
    private static int B=10;
    private static string a;
    private static string b;

    private int num_password;
    private int realpassword=35;
   

    //얘도 그림클릭하면 키패드 뜨게????
    public void Pwdclose()
    {
        keypad_number.SetActive(false);
        anscanvas.SetActive(false);
	}

    public void Backspace()
    {
		if (B != 10) {
			B = 10;
			pwdtxt.text = a;
			b = null;
		} else if (A != 10) {
			A = 10;
			pwdtxt.text = " ";
			a = null;
		} else {
			a = null;
			b = null;
			A = 10;
			B = 10;
			pwdtxt.text = " ";
		}
        //Debug.Log("back"+a + b);

    }

    void Input_number(int number)
    {
		if (A == 10) {
			A = number;
			a = number.ToString ();
			pwdtxt.text = a;
		} else if (B == 10) {
			B = number;
			b = number.ToString ();
			pwdtxt.text = a + b;
        
        
			num_password = (10 * A + B);
			if (num_password == realpassword) {
				//pwdtxt.text = " * C O L L E C T *";
				//35답이 맞을경우 구체적으로 어떤이벤트 발생시킬지
				Invoke ("CollectAnswer", 2);
			} else { 
				A = 10;
				B = 10;
				pwdtxt.text = "Retry";
			}
		}
        //Debug.Log(a + b);
	}

    void CollectAnswer()
    {
        keypad_number.SetActive(false);
        anscanvas.SetActive(false);
        hex_before.SetActive(false);
        hex_after.SetActive(true);
		door_before.SetActive (false);
		door_after.SetActive (true);
		//탈출
    }

    public void Number1()
    {
        Input_number(1);
    }

    public void Number2()
    {
        Input_number(2);
    }

    public void Number3()
    {
        Input_number(3);
    }

    public void Number4()
    {
        Input_number(4);
    }

    public void Number5()
    {
        Input_number(5);
    }

    public void Number6()
    {
        Input_number(6);
    }

    public void Number7()
    {
        Input_number(7);
    }

    public void Number8()
    {
        Input_number(8);
    }

    public void Number9()
    {
        Input_number(9);
    }

    public void Number0()
    {
        Input_number(0);
    }



}