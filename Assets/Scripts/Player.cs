using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public AudioClip Get_Sound;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter(Collider collision)
        //取得寶石播放音樂
    {
        if (collision.gameObject.tag == "Gem")
        //如果碰到"Gem"tag
        {
            GetComponent<AudioSource>().PlayOneShot(Get_Sound);
        }
    }

}
