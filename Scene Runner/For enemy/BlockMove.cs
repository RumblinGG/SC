using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
{
    public float Sp;
    public Transform player;
    void Start()
    {
        Sp = 7;
    }

    void Update()
    {
    transform.Translate(Vector3.forward*Sp*Time.deltaTime);
          if  (transform.position.z > -828.49f)
        Sp = -Sp;
        if  (transform.position.z < -873.23f)
         Sp = 7 ;       
    }
}
