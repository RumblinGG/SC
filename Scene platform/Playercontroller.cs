using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
public float Speed = 150f;
    private Rigidbody _rb;

    void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
private void FixedUpdate() {
    float h = Input.GetAxis("Horizontal");
    float v = Input.GetAxis("Vertical");
     _rb.AddForce(new Vector3(h,1,v)*Speed*Time.fixedDeltaTime); 
   //  _rb.velocity = transform.TransformDirection(new Vector3(v,0,h));
}

}