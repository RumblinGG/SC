using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrustforWall2 : MonoBehaviour
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
    _rb.AddForce(new Vector3(1,0.5f,0)*trust);  
    }
    
}