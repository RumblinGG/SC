using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Basics : MonoBehaviour
{
public   GameObject[]  objs = new GameObject[3];   
public Transform target;
public BoxCollider box;
public Light svet;
public Transform[] transforms = new Transform[3];
public float Speed = 0.2f, Rotspeed = 1f;
private void Start() {
   // Cube.SetActive(false);
   // Cube.GetComponent<BoxCollider>().position = new Vector3(10,0,5);
//   target.position = new Vector3 (10,0,5);
//   svet.intensity=0.5f;

//   for(int i = 0; i<objs.Length; i++)
//  objs[i].SetActive(false);
}
private void Update() {
 for(int i=0; i<transforms.Length;i++)
 {
   if(transforms[i]  == null)
   continue;

  transforms[i].Translate(new Vector3(-1,0,0)*Speed*Time.deltaTime);
  transforms[i].Rotate(new Vector3(2,0,0)*Rotspeed*Time.deltaTime);
  float posX = transforms[i].position.x;
  if(posX < -10f  && transforms[i].gameObject.name == "Cube")
  Destroy(transforms[i].gameObject);
 }  
   
}




}