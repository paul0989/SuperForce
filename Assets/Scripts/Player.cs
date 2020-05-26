using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioClip Get_Sound;
    public AudioClip EnemyHit_Sound;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    //取得寶石播放音樂
    {
        if (collision.gameObject.tag == "Gem" || collision.gameObject.tag == "Healthpack")
        //如果碰到"Gem"tag
        {
            GetComponent<AudioSource>().PlayOneShot(Get_Sound);
        }
    }

    private void OnCollisionEnter(Collision collision)
    //當物件碰撞到 物件時(可碰撞的對象帶有Collision 可碰撞對象引數名稱)
    {
        if (collision.gameObject.tag == "EnemyTank_Bullet" || collision.gameObject.tag == "EnemyCar_Bullet")
        //如果碰到"EnemyTank_Bullet"或"EnemyCar_Bullet"tag
        {
            GetComponent<AudioSource>().PlayOneShot(EnemyHit_Sound);
        }
    }

}
