using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEditor;
using UnityEngineInternal;
using UnityEditorInternal;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
   public  Text scoreText;
   private int _score = 0;
 private void OnTriggerEnter(Collider other)
 {
  if(gameObject.name == "Col") 
 {
    _score++;
    Destroy(other.gameObject);
    if   (_score != 5) 
        scoreText.text = "Score: " + _score;
        
    else
     scoreText.text = "Congratulations! " + _score;

  }
 
 }        
 }

