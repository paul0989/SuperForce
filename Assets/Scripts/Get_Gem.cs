using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Gem : MonoBehaviour {
    public AudioClip Get_Sound;
	// Use this for initialization
	void Start () {
		
	}
  
    // Update is called once per frame
    void Update () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        //如果碰到"Player"tag
        {
            GetGem_Total.Gem_Num+=1;
            //寶石取得+1
            //print("Gem_Num:" + GetGem_Total.Gem_Num);
            //GetComponent<AudioSource>().PlayOneShot(Get_Sound);
            Destroy(gameObject);
            //寶石刪除
        }
    }
}
