using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveplayer : MonoBehaviour
{
    public float Speed = 200f,Hspeed = 150f, _trust =500f;
    private Rigidbody _rb;
    private void Awake() {
        _rb=GetComponent<Rigidbody>();
    }
private void FixedUpdate() {
    float h = Input.GetAxis("Horizontal")*Speed*Time.fixedDeltaTime;
    float v = Input.GetAxis("Vertical")*Speed*Time.fixedDeltaTime;

  _rb.velocity = transform.TransformDirection(new Vector3(_rb.velocity.x,v,h));
}
 private void OnCollisionEnter(Collision other) {
    if(other.gameObject.name == "Block")
    {
      _rb.AddForce(new Vector3(0,0,1)*_trust);  
    }
//  }
//  private void OnCollisionStay(Collision other) {
    // Debug.Log("Coll");
 }
 private void OnCollisionExit(Collision other) {
    Debug.Log("Coll");
    
 }
 private void OnTriggerEnter(Collider other) {
    if(other.gameObject.name == "trig")
    Debug.Log("Trig correct"); }
 private void OnTriggerStay(Collider other) {
     if(other.gameObject.name == "trig")
    Debug.Log("Staymant"); }
 private void OnTriggerExit(Collider other) {
    if(other.gameObject.name == "trig")
    Destroy(gameObject);
 }





































// private void Update() { //Передвижения
    // if(Input.GetKey(KeyCode.D) || Input.GetKeyUp(KeyCode.UpArrow))
    // transform.Translate(new Vector3(1,0,0)*Time.deltaTime*Speed);
    //     if(Input.GetKey(KeyCode.A) || Input.GetKeyUp(KeyCode.DownArrow))
    // transform.Translate(new Vector3(1,0,0)*Time.deltaTime*-Speed);
    //     if(Input.GetKey(KeyCode.W) || Input.GetKeyUp(KeyCode.LeftArrow))
    // transform.Translate(new Vector3(0,1,0)*Time.deltaTime*Speed);
    //     if(Input.GetKey(KeyCode.S) || Input.GetKeyUp(KeyCode.RightArrow))
    // transform.Translate(new Vector3(0,1,0)*Time.deltaTime*-Speed);
//  float u = Input.GetAxis("Vertical");
//   transform.Translate(new Vector3(0,1,0)*Time.deltaTime*Speed*u);
//     float h = Input.GetAxis("Horizontal");
//   transform.Translate(new Vector3(0,0,1)*Time.deltaTime*Speed*h);
// }
}
