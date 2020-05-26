using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar_Detection : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "EnemyCar_Point" || other.gameObject.tag == "EnemyTank_Point" )
        {
            other.gameObject.GetComponent<MeshRenderer>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "EnemyCar_Point" || other.gameObject.tag == "EnemyTank_Point")
        {
            other.gameObject.GetComponent<MeshRenderer>().enabled = false;
        }

    }

}
