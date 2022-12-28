using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrustforWall3 : MonoBehaviour
{
public float trust =500f;
 public Rigidbody _rb;
    void Start()
    {
       _rb.GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision other) 
    {
    if(other.gameObject.name == "Player")
    _rb.AddForce(new Vector3(0,0.5f,0.5f)*trust);  
    }
    
}