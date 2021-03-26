using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrol : MonoBehaviour
{
    [SerializeField] float movespeed = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Move_right"))
        {
            gameObject.transform.Translate(-Vector3.right * movespeed * Time.deltaTime);

        }
       else if (Input.GetButton("Move_left"))
        {
            gameObject.transform.Translate(Vector3.right * movespeed * Time.deltaTime);

        }
    }
}
