using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Life : MonoBehaviour {
    public static int Life_Num = 10;
    //血量全域變數(血量歸0)
    public GameObject Game_Fail_UI;
    //任務失敗UI
    public GameObject Game_Finish_UI;
    //任務成功UI
    // Use this for initialization
    void Start () {
        Life_Num = 10;
        //重新開始時血量回復用
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Life_Num <= 0)
        {
            Game_Fail_UI.SetActive(true);
            //顯示任務失敗UI
            SceneManager.LoadScene("Game_Start");
            //回到開啟遊戲畫面
        }
        if(Life_Num>0 && GetGem_Total.Gem_Num==4)
            //生命值>0而且取得4顆寶石
        {
            Game_Finish_UI.SetActive(true);
            //顯示任務成功UI
            StartCoroutine("GamePass");
            //過關後不要馬上跳回起始畫面
        }
    }
    IEnumerator GamePass()
    {
        yield return new WaitForSeconds(0.7f);
        SceneManager.LoadScene("Game_Start");
        //回到開啟遊戲畫面
    }
}
