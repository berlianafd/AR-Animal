using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
     public void PindahHalaman(string halaman)
    {
        SceneManager.LoadScene(halaman);
    }
    public void GoToMainMenu()
    {
        Application.LoadLevel("main_menu");
    }
    public void GoToARCamera()
    {
        Application.LoadLevel("ARCameraMain");
    }
    public void GoToGuideScene()
    {
        Application.LoadLevel("scene_guide");
    }
    public void GoToJaguarScene()
    {
        Application.LoadLevel("scene_jaguar");
    }
    public void exitaplikasi()
    {
        Application.Quit();
    }
}
