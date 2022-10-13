using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
     private void OnCollisionExit(Collision other) {
    Debug.Log("Kill");
    
 }
  private void OnTriggerEnter(Collider other)
 {
    if((other.gameObject.name == "Cube (1)") || 
    (other.gameObject.name == "Cube (2)")||
    (other.gameObject.name == "Cube (3)")||
    (other.gameObject.name == "Cube (4)"))
    Destroy(gameObject);
 }

}
