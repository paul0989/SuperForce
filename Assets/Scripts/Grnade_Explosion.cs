using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grnade_Explosion : MonoBehaviour {
    public GameObject Smoke;
    //爆炸(音效放粒子系統)
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    //當物件碰撞到 物件時(可碰撞的對象帶有Collision 可碰撞對象引數名稱)
    {
        if (collision.gameObject.tag == "Enemy_Car" || collision.gameObject.tag == "Enemy_Tank" || collision.gameObject.tag == "Rock")
        //碰到"Enemy_Car或Enemy_Tank"tag的物件
        {
            Instantiate(Smoke, transform.position, transform.rotation);
            //生成爆炸特效
            Destroy(gameObject);
            //刪除手榴彈
            Destroy(collision.gameObject, 0.3f);
            //碰撞到的物件0.3f後消失
        }
        else
        {
            StartCoroutine(Grnade_Explode());
            //如果都沒碰撞到的話延遲爆炸
        }
    }

    IEnumerator Grnade_Explode()
    {
        yield return new WaitForSeconds(3);
        Instantiate(Smoke, transform.position, transform.rotation);
        //生成爆炸特效
        Destroy(gameObject);
        //刪除手榴彈
    }

}
