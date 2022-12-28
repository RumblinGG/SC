using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Timers;
public class Murderers : MonoBehaviour
{
void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Player")
        //  new WaitForSeconds(3);
        SceneManager.LoadScene("Runner");   
    }
}
