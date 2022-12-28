using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCubes : MonoBehaviour
{
    public float Sp;
    public Transform player;
    void Start()
    {
        Sp = 5;
    }
    void Update()
    {
        transform.Translate(Vector3.right*Sp*Time.deltaTime);
        if  (transform.position.x > 4f)
        Sp = -Sp;
        if  (transform.position.x < -19.45981f)
        Sp = 5 ;        
    }
}
