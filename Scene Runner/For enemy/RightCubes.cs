     using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCubes : MonoBehaviour
{
    public float Sp;
    public Transform player;
    void Start()
    {
        Sp = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left*Sp*Time.deltaTime);
        if  (transform.position.x < -19.45981f)
        Sp = -Sp;
        if  (transform.position.x > 4f)
        Sp = 5 ;        
    }
}
