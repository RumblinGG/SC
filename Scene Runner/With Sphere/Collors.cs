using UnityEngine;

public class Collors : MonoBehaviour
{
private MeshRenderer _mesh;
private void Awake() 
{
    _mesh = GetComponent<MeshRenderer>();
}
//Заміна матеріалів
private void Update() 
{
    if(Input.GetKeyUp(KeyCode.G))
    _mesh.material.color = Color.green;

    if(Input.GetKeyUp(KeyCode.R))
    _mesh.material.color = Color.red;

    if(Input.GetKeyUp(KeyCode.B))
    _mesh.material.color = Color.blue;
}
}