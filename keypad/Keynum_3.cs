using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keynum_3 : MonoBehaviour {

    public Text pwdtxt;
    public GameObject keypad_number;

    public GameObject boardbefore;
    public GameObject boardafter;

	public GameObject treasure1;
	public GameObject treasure2;
    /*
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
    */

    public static int A=10;
    public static int B=10;
    public static int C=10;
    public static string a;
    public static string b;
    public static string c;

    public int num_password;
    public int realpassword=436;
   

    
    public void Pwdclose()
    {
        keypad_number.SetActive(false);
	}

    public void Backspace()
    {
        if (C != 10)
        {
            C = 10;
            pwdtxt.text = a + b;
        }
        else if (B != 10)
        {
            B = 10;
            pwdtxt.text = a;
        }
        else if (A != 10)
        {
            A = 10;
            pwdtxt.text = " ";
        }
      else pwdtxt.text = " ";
        Debug.Log("back");
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
		} else if (C == 10) {
			C = number;
			c = number.ToString ();
			pwdtxt.text = a + b + c;
        
			num_password = (100 * A + 10 * B + C);
			if (num_password == realpassword) {
				//pwdtxt.text = " * C O L L E C T *";
				boardbefore.SetActive (false);
				boardafter.SetActive (true);
				Invoke ("CollectAnswer", 2);
				treasure1.SetActive (false);
				treasure2.SetActive (true);
			} else { 
				A = 10;
				B = 10;
				C = 10;
				pwdtxt.text = "retry";
			}
		}
        Debug.Log(a + b + c);
	}

    void CollectAnswer()
    {
        keypad_number.SetActive(false);

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