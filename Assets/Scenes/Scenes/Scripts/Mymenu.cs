using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mymenu : MonoBehaviour
{
    public void MulaiGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -0);
    }
    public void KeluarGame()
    {
        Application.Quit();
        Debug.Log("Keluar");
    }
}
