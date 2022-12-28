using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulMove : MonoBehaviour
{
    public Transform Caps;
    public Transform point2;
    public Transform point3;

    public float speed;
    void Start()
    {
        speed = 0.02f;
    }
    void Update()
    {
    // transform.position = Vector3.MoveTowards(Caps.position, point2.position,speed);
    // if(Caps.position == point2.position)
    // transform.position = Vector3.MoveTowards(Caps.position, point3.position,speed);
    // if(other.CompareTag ("Point3"))
    // transform.position = Vector3.MoveTowards(Caps.position, point2.position,speed);
    }
}
