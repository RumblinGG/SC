using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrustOnStart : MonoBehaviour
{
 public float trust =500f;
 public Rigidbody _rb;
    void Start()
    {
       _rb.GetComponent<Rigidbody>() ;
    } 
    void OnCollisionEnter(Collision other) 
    {
    if(other.gameObject.name == "Player")
    _rb.AddForce(new Vector3(0,1,1)*trust);  
    }
    
}