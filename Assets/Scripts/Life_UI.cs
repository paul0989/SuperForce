using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life_UI : MonoBehaviour {
    public Image Show_Life_UI;
    //UI元件
    public Sprite[] Sprite_Texture;
    //Sprite圖片

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Player_Life.Life_Num == 10)
        //血量10(陣列0~9)
        {
            Show_Life_UI.sprite = Sprite_Texture[9];
        }
        if (Player_Life.Life_Num == 9)
        {
            Show_Life_UI.sprite = Sprite_Texture[8];
        }
        if (Player_Life.Life_Num == 8)
        {
            Show_Life_UI.sprite = Sprite_Texture[7];
        }
        if (Player_Life.Life_Num == 7)
        {
            Show_Life_UI.sprite = Sprite_Texture[6];
        }
        if (Player_Life.Life_Num == 6)
        {
            Show_Life_UI.sprite = Sprite_Texture[5];
        }
        if (Player_Life.Life_Num == 5)
        {
            Show_Life_UI.sprite = Sprite_Texture[4];
        }
        if (Player_Life.Life_Num == 4)
        {
            Show_Life_UI.sprite = Sprite_Texture[3];
        }
        if (Player_Life.Life_Num == 3)
        {
            Show_Life_UI.sprite = Sprite_Texture[2];
        }
        if (Player_Life.Life_Num == 2)
        {
            Show_Life_UI.sprite = Sprite_Texture[1];
        }
        if (Player_Life.Life_Num == 1)
        {
            Show_Life_UI.sprite = Sprite_Texture[0];
        }
        if (Player_Life.Life_Num == 0)
        {
            Show_Life_UI.enabled = false;
            //血量0的時候關掉
        }

    }
}
