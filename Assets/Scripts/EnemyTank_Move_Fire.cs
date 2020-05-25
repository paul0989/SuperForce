using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTank_Move_Fire : MonoBehaviour {
    public GameObject Player;
    public Rigidbody Bullet_Source;
    //子彈
    public GameObject Fire_Point;
    //子彈生成點
    private Rigidbody TankForce;
    //對Tank施力
    private int count;
    //測試施力次數用
    Vector3 m_StartPos, m_StartForce;
    Vector3 m_NewForce;

    public float m_ForceX;
    public float m_ForceY;
    public float m_ForceZ;
    //施加力量


    public GameObject Fire_Particle;
    //開槍火花
    public AudioClip Fire_Sound;
    //開槍音效

    public int Fire_Y = -1;
    public int Fire_Z = 50;
    //子彈射擊出去的距離及高度
    public float Move_Speed=0.05f;
    //移動速度
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
        TankForce = GetComponent<Rigidbody>();
        count = 0;
        //施力次數歸0
        //m_NewForce = new Vector3(0f, 0f, 0f);
        //m_ForceX = 0;
        //m_ForceY = 0;

        //m_StartPos = transform.position;
        //m_StartForce = TankForce.transform.position;
        //m_NewForce = new Vector3(m_ForceX, m_ForceY, m_ForceZ);


    }
    float timer = 0;
    private void FixedUpdate()
    {
        //print("質量:" + TankForce.mass + " 施力次數:" + count);
        Dis = Vector3.Distance(transform.position, Player.transform.position);
        timer += Time.deltaTime;
        //判斷距離(Enemy到Player的距離)
        if (Dis < Move_Dis_Num && timer > 1.0f)
        {
            transform.LookAt(Player.transform);
            //面朝(player)的方向
            //transform.position = m_StartPos;
            //TankForce.transform.position = m_StartForce;
            //TankForce.velocity = new Vector3(0f, 0f, 0f);

            //TankForce.AddForce(0, 0, thrust, ForceMode.Force);
            //TankForce.AddForce(transform.forward * thrust);
            TankForce.AddForce(Vector3.forward*100);
            timer = 0;
            count++;

        }

    }

    // Update is called once per frame
    void Update () {
        Dis = Vector3.Distance(transform.position, Player.transform.position);
        //判斷距離(Enemy到Player的距離)
        //if (Dis < Move_Dis_Num)
        //如果兩者實際距離<Move_Dis_Num
        //{
            //transform.LookAt(Player.transform);
            //面朝(player)的方向
            //transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, Move_Speed);
            //從目前位置朝著(Player)方向前進,速度(0.05f)
            if(Dis< Fire_Dis_Num)
            //如果實際距離<Fire_Dis_Num
            {
                i += Time.deltaTime;
                //重0開始隨時間累加上去
                if(i>3)
                {
                    Rigidbody Bullet = Instantiate(Bullet_Source, Fire_Point.transform.position, Fire_Point.transform.rotation);
                    //生成子彈(Bullet_Source物件,Fire_Point位置,Fire_Point方向)
                    Instantiate(Fire_Particle, Fire_Point.transform.position, Fire_Point.transform.rotation);
                    //生成射擊特效
                    GetComponent<AudioSource>().PlayOneShot(Fire_Sound);
                    //播放射擊音效
                    Bullet.velocity = transform.TransformDirection(new Vector3(0, Fire_Y, Fire_Z));
                    //子彈加速度  控制加速度的方向 
                    i = 0;
                    //計時器歸0
                }
            }
        //}
	}
}
