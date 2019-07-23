using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch_MapCam : MonoBehaviour {
    public GameObject MapCam;
    public GameObject UI_Life_Gem_Aim;
    public AudioClip Sound;
    private bool KeyState = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.M))
            //按下鍵盤M的時候
        {
            GetComponent<AudioSource>().PlayOneShot(Sound);
            if(KeyState==false)
            {
                MapCam.SetActive(true);//啟動MapCam
                UI_Life_Gem_Aim.SetActive(false);//關閉Life.Gem.AimUI
                KeyState = true;
            }
            else
            {
                MapCam.SetActive(false);//關閉MapCam
                UI_Life_Gem_Aim.SetActive(true);//啟動Life.Gem.AimUI
                KeyState = false;
            }
        }
	}
}
