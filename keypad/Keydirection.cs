using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keydirection : MonoBehaviour {

    public GameObject keydirection;

    private static string dir1 = null;
    private static string dir2 = null;
    private static string dir3 = null;
	private static string tem1 = null;
	private static string tem2 = null;
	private static string tem3 = null;
	public Text txt;


    //up:U down:D left:L right:R

    private string realpwd="LDL";
	private static string inputpwd = null;

    private void InputDirection(string temp)
    {
		if (dir1 == null) {
			dir1 = temp;
			tem1 = "*";
		} 
		else if (dir2 == null) {
			dir2 = temp;
			tem2 = "*";
		} 
		else if (dir3 == null) {
			dir3 = temp;
			tem3 = "*";
		}
		inputpwd = dir1 + dir2 + dir3;
		if (inputpwd == realpwd) {
			//탈출
			keydirection.SetActive(false);
		}
		txt.text = tem1 + tem2 + tem3;
        //Debug.Log("input"+inputpwd);
    }

    private void BackSpace()
    {
        if (dir3 != null)
        {
            dir3 = null;
			tem3 = null;
        }
        else if (dir2 != null)
        {
            dir2 = null;
			tem2 = null;
        }
        else if (dir1 != null)
        {
            dir1 = null;
			tem1 = null;
        }
        inputpwd = dir1 + dir2 + dir3;
		txt.text = tem1 + tem2 + tem3;
        //Debug.Log("back" + inputpwd);
    }

    public void InputBackspace()
    {
        BackSpace();
    }

    public void InputClose()
    {
        keydirection.SetActive(false);
		dir1 = null;
		dir2 = null;
		dir3 = null;
		tem1 = null;
		tem2 = null;
		tem3 = null;
    }

    public void InputUp()
    {
        InputDirection("U");
    }

    public void InputDown()
    {
        InputDirection("D");
    }

    public void InputLeft()
    {
        InputDirection("L");
    }
    
    public void InputRight()
    {
        InputDirection("R");
    }
}
