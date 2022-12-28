using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Meneger : MonoBehaviour
{
public void loadlevel()
{
Debug.Log ("start game!");
SceneManager.LoadScene("Runner");
}
public void ExitGame()
{
Debug.Log("Exit Game");
Application.Quit();   
}
}
