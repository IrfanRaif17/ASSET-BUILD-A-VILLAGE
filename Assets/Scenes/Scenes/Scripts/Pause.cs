using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{

    public GameObject Canvas;
    public GameObject Camera;
    public bool Paused = false;

    void Start()
    {
        Canvas.SetActive(false);
        Paused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (Paused == false)
            {
                Time.timeScale = 0.0f;
                Canvas.SetActive(true);
                Cursor.visible = true;
                Screen.lockCursor = true;
                Camera.GetComponent<AudioSource>().Pause();
                Paused = true;
            }
            else
            {
                Time.timeScale = 1.0f;
                Canvas.SetActive(false);
                Cursor.visible = false;
                Screen.lockCursor = true;
                Camera.GetComponent<AudioSource>().Play();
                Paused = false;
            }
        }
    }
    public void Resume()
    {
        Time.timeScale = 1.0f;
        Canvas.SetActive(false);
        Cursor.visible = false;
        Screen.lockCursor = true;
        Camera.GetComponent<AudioSource>().Play();
    }
}