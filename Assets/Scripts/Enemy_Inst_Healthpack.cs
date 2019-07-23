using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Inst_Healthpack : MonoBehaviour {
    public GameObject Healthpack;
    //補血包
    public GameObject Healthpack_point;
    //補血包生成點
    private int Random_Num;
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Player_bullet" || collision.gameObject.tag == "Grnade")
        //石頭碰撞到"子彈"或是"手榴彈"tag時生成寶石
        {
            Random_Num = Random.Range(0, 5);
            //0~4之間取五個亂數值出來
            print("Random_Num" + Random_Num);
            if (Random_Num <= 1)
            {
                Instantiate(Healthpack, Healthpack_point.transform.position, transform.rotation);
                //生成(寶石,寶石點位置,寶石點方向)
            }
        }
    }
}
