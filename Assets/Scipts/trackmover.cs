using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackmover : MonoBehaviour
{
    [SerializeField] float movetrack = 0f;
    [SerializeField] GameObject trackprefeb;
    private float distanceofdeletion =  100f;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(  - Vector3.left * Time.deltaTime * movetrack);
       // if(gameObject.transform.position.x <=  distanceofdeletion)
        //{
       //    Destroy (gameObject.transform.GetChild(0).gameObject);
         //   distanceofdeletion = distanceofdeletion + 100;
         //  GameObject temp = Instantiate(trackprefeb, Vector3.zero, Quaternion.identity);
           // temp.transform.position = new Vector3(gameObject.transform.GetChild(gameObject.transform.childCount - 1).transform.position.x + 100f,0,0);
          // temp.transform.parent = gameObject.transform;
       // }
    }
}
