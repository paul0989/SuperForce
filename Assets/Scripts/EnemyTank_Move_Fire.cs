﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTank_Move_Fire : MonoBehaviour {
    public GameObject Player;
    public Rigidbody Bullet_Source;
    //子彈
    public GameObject Fire_Point;
    //子彈生成點
    public GameObject Fire_Particle;
    //開槍火花
    public int Fire_Y = 1;
    public int Fire_Z = 50;
    //子彈射擊出去的距離及高度
    public int Move_Dis_Num = 100;
    //觸發移動距離
    public int Fire_Dis_Num = 70;
    //觸發開火距離
    private float Dis;
    //Enemy跟Player的距離
    private float i;
    //Enemy開火頻率(計時用)


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Dis = Vector3.Distance(transform.position, Player.transform.position);
        //判斷距離(Enemy到Player的距離)
        if (Dis < Move_Dis_Num)
        //如果兩者實際距離<Move_Dis_Num
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, 0.05f);
            //從目前位置朝著(Player)方向前進,速度(0.05f)
            transform.LookAt(Player.transform);
            //面朝(player)的方向
            if(Dis< Fire_Dis_Num)
            //如果實際距離<Fire_Dis_Num
            {
                i += Time.deltaTime;
                //重0開始隨時間累加上去
                if(i>1)
                {
                    Rigidbody Bullet = Instantiate(Bullet_Source, Fire_Point.transform.position, Fire_Point.transform.rotation);
                    //生成子彈(Bullet_Source物件,Fire_Point位置,Fire_Point方向)
                    Instantiate(Fire_Particle, Fire_Point.transform.position, Fire_Point.transform.rotation);
                    //生成開火特效
                    Bullet.velocity = transform.TransformDirection(new Vector3(0, Fire_Y, Fire_Z));
                    //子彈加速度  控制加速度的方向 
                    i = 0;
                    //計時器歸0
                }
            }
        }
	}
}