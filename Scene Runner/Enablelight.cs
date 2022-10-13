
using UnityEngine;

public class Enablelight : MonoBehaviour
{

public Light _mainlight;

    private void Update() {
    if(Input.GetKeyUp(KeyCode.Space))
    _mainlight.enabled = !_mainlight.enabled;
}



}
