using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw_Grnade : MonoBehaviour {

    public Rigidbody Grnade_Source;

    public int Throw_Z = 30;
    public int Throw_Y = 2;
    //投擲距離,高度
    public AudioClip Throw_Sound;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        //當按下滑鼠右鍵
        {
            Rigidbody Grnade = Instantiate(Grnade_Source, transform.position, transform.rotation);
            Grnade.velocity = transform.TransformDirection(new Vector3(0, Throw_Y, Throw_Z));
            //                          控制加速度的方向  
            GetComponent<AudioSource>().PlayOneShot(Throw_Sound);
        }

    }
}
