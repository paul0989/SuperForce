using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Myself : MonoBehaviour {

    public int X_Rotate = 0;
    public int Y_Rotate = 0;
    public int Z_Rotate = 0;

    //public int Deg;
    //
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(0 * Time.deltaTime, Deg * Time.deltaTime, 0 * Time.deltaTime);
        transform.Rotate(X_Rotate * Time.deltaTime, Y_Rotate * Time.deltaTime, Z_Rotate * Time.deltaTime);
    }

}
