using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get_Healthpack : MonoBehaviour
{
    //public AudioClip Get_Sound;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        //如果碰到"Player"tag
        {
            if (Player_Life.Life_Num < 10)
            {
                Player_Life.Life_Num += 1;
                //補血包取得+1
                print("Life"+Player_Life.Life_Num);
            }
            //print("Healthpack_Total:" + Get_Healthpack_Total.Healthpack_Total);
            //GetComponent<AudioSource>().PlayOneShot(Get_Sound);
            Destroy(gameObject);
            //寶石刪除
        }
    }
}
