using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Fire : MonoBehaviour {
    public Rigidbody Bullet;
    //子彈

    public int Throw_Z = 30;
    public int Throw_Y = 2;
    //投擲距離,高度

    public GameObject Fire_Particle;
    //開槍特效
    public AudioClip Fire_Sound;
    //開槍音效

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        //GetMouseButtonDown按下左鍵(0)，(右鍵是1)
        {
            //Instantiate(Bullet, transform.position, transform.rotation);
            //生成(子彈,該物件位置,該物件旋轉方向)
            Rigidbody Grnade = Instantiate(Bullet, transform.position, transform.rotation);
            Grnade.velocity = transform.TransformDirection(new Vector3(0, Throw_Y, Throw_Z));
            //                          控制加速度的方向  
            Instantiate(Fire_Particle, transform.position, transform.rotation);
            GetComponent<AudioSource>().PlayOneShot(Fire_Sound);
            //取得<聲音元件>().播放一次(音效變數名稱);
        }
    }

}
