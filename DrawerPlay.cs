using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerPlay : MonoBehaviour {

    private int animmode2 = 1;
    private int animmode3 = 1;
    private int animmode5 = 1;
    private int animmode7 = 1;
    private int animmode8 = 1;

    public Animation anim;

	public void PlayAnim2()
	{
        if (animmode2 == 1)
        {
            anim["room2_2"].time = 0;
        }
        else
        {
            anim["room2_2"].time = anim["room2_2"].length;
        }
        anim["room2_2"].speed = animmode2;
        anim.Play("room2_2");    
		animmode2 = animmode2 * (-1);
	}

    public void PlayAnim3()
    {
        if (animmode3 == 1)
        {
            anim["room2_3"].time = 0;
        }
        else
        {
            anim["room2_3"].time = anim["room2_3"].length;
        }
        anim["room2_3"].speed = animmode3;
        anim.Play("room2_3");
        animmode3 = animmode3 * (-1);
    }

    public void PlayAnim5()
    {
        if (animmode5 == 1)
        {
            anim["room2_5"].time = 0;
        }
        else
        {
            anim["room2_5"].time = anim["room2_5"].length;
        }
        anim["room2_5"].speed = animmode5;
        anim.Play("room2_5");
        animmode5 = animmode5 * (-1);
    }

    public void PlayAnim7()
    {
        if (animmode7 == 1)
        {
            anim["room2_7"].time = 0;
        }
        else
        {
            anim["room2_7"].time = anim["room2_7"].length;
        }
        anim["room2_7"].speed = animmode7;
        anim.Play("room2_7");
        animmode7 = animmode7 * (-1);
    }

    public void PlayAnim8()
    {
        if (animmode8 == 1)
        {
            anim["room2_8"].time = 0;
        }
        else
        {
            anim["room2_8"].time = anim["room2_8"].length;
        }
        anim["room2_8"].speed = animmode8;
        anim.Play("room2_8");
        animmode8 = animmode8 * (-1);
    }
    // Use this for initialization
    void Start () {
		anim = GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
