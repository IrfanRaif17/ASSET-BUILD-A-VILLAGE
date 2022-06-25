using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputUser : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, 100) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -100) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(100, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-100, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.U))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.I))
        {
            transform.Rotate(0, -1, 0);
        }

        if (Input.GetKey(KeyCode.Delete))
        {
            Destroy(gameObject);
        }
    }
}
