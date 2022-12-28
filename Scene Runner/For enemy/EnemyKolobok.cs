using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyKolobok : MonoBehaviour
{
public Transform player;    
public float Sp = 10f;
public GameObject Player;

    void Start()
    {
    
    }


    public void Update()
    {

        float step = Sp*Time.deltaTime;
        
        transform.position = Vector3.MoveTowards(transform.position, player.position, step);
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Player")
        SceneManager.LoadScene("Runner");   
    }
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
   
    // public void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Player"))
    //     transform.position = Vector3.MoveTowards(transform.position, player.position, fallow);
    // }


}

