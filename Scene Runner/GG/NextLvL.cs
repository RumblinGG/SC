using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLvL : MonoBehaviour
{
 
    void Start()
    {
        
    }
public void OnTriggerEnter(Collider other) {
    if(other.gameObject.tag == "Player")
    SceneManager.LoadScene("Platform");
    }

    void Update()
    {
        
    }
}
