using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerascript : MonoBehaviour
{
private Transform player;
void Start()
{
     player = GameObject.FindWithTag("Player").transform;
}
void Update()
{
Vector3 temp = transform.position;
temp.y = player.position.y+2;
temp.z = player.position.z;
temp.x = player.position.x+20;

transform.position = temp;
}





}
