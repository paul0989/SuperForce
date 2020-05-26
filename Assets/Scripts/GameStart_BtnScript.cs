using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart_BtnScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play_Fun()
    {
        SceneManager.LoadScene("Game");
        //載入Game場景
    }

    public void Exit_Fun()
    {
        Application.Quit();
        //離開
    }

}
