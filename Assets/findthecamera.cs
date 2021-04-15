using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findthecamera : MonoBehaviour
{
    Transform car;
    void Start()
    {
        car = GameObject.Find("car").transform;
    }


    void Update()
    {
        if (transform.position.x<car.position.x+1)
        {
            transform.Translate(.1f, 0, 0);

        }
    }
}
