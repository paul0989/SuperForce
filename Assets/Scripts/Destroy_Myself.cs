using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Myself : MonoBehaviour
{
    public float Destroy_Time = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, Destroy_Time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
