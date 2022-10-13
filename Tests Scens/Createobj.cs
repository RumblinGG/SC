using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity;
public class Sozdanie1 : MonoBehaviour
{
public GameObject[] obj;

public void Update() {
  // Invoke("Create", 20f);
  if(Input.GetKeyUp(KeyCode.U))
 StartCoroutine(Creat3Dojec(2f));
}
private void Create() 
{
  for(int i = 0;    i<5;    i++){

//    GameObject newObject = Instantiate(obj,new Vector3(0,5,0), Quaternion.Euler(12f,-15f,75f) ) as   GameObject;
//    newObject.GetComponent<Transform>().position=new Vector3(4,5,3);
    Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(),RandomNumber(),RandomNumber()),  Quaternion.Euler(RandomNumber(),-15f,RandomNumber()) );
}
}
private int RandomNumber(){ // Замена ренджи
    return UnityEngine.Random.Range(0, 10);
}
private IEnumerator Creat3Dojec(float wait){
   while(true){ // Автоматическая генерация
 Instantiate(obj[UnityEngine.Random.Range(0, obj.Length)], new Vector3(RandomNumber(),RandomNumber(),RandomNumber()),  Quaternion.Euler(RandomNumber(),-15f,RandomNumber()) );
 yield return new WaitForSeconds(wait);
  }
  // РУЧНОЙ МЕТОД КОНТРОЛЯ  yield return new WaitForSeconds(wait);\
  // Create(); 
  // Debug.Log("Log");
}
}