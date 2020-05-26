﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Bullet_Move : MonoBehaviour {
    public GameObject Smoke;
    //子彈擊中時煙霧
    public float MoveSpeed = 30;
    //子彈速度
    public float Destroy_Time = 1.5f;
    //子彈刪除時間

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, Destroy_Time);
        //1.5秒後刪除
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0*Time.deltaTime,0*Time.deltaTime, MoveSpeed*Time.deltaTime);
        //無法偵測碰撞效果
    }

    private void OnCollisionEnter(Collision collision)
    //當物件碰撞到 物件時(可碰撞的對象帶有Collision 可碰撞對象引數名稱)
    {
        Instantiate(Smoke, transform.position, transform.rotation);
        //生成爆炸特效
        if (collision.gameObject.tag == "Enemy_Car" || collision.gameObject.tag == "Enemy_Tank" || collision.gameObject.tag == "Rock")
        //碰到"Enemy_Car或Enemy_Tank"tag的物件
        {
            Destroy(collision.gameObject, 0.1f);
            //碰撞到的物件0.1f後消失
        }
        Destroy(gameObject);
        //刪除子彈
    }
}
