using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KillPlayer : MonoBehaviour
{
   public int Respawn;
    void Start()
    {
        
    }



public void OnTriggerEnter(Collider other)

{
if ((other.CompareTag("Player")) || (Input.GetKeyDown(KeyCode.Z)))
SceneManager.LoadScene(Respawn);  
}











    

  
//   private void OnCollisionEnter(Collision other)
//   {
//     if(other.gameObject.name != "Player" )
//     SceneManager.LoadScene(Respawn);
//     }
}