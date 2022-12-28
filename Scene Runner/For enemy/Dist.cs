using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Dist : MonoBehaviour
{
public Transform player;    
public float Sp = 7f;
public GameObject Player;

    void Start()
    {
    
    }


    public void Update()
    {
    float dist  = Vector3.Distance(player.position, transform.position);  
        if(dist > 12)
        transform.Translate(Vector3.right*Sp*Time.deltaTime);
        if (transform.position.y > 8.49f)
        Sp = -Sp;
        if  (transform.position.y < 0.23f)
        Sp = 7 ;    
        else
        {
        float step = Sp*Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Player")
        SceneManager.LoadScene("Runner");   
    }
}