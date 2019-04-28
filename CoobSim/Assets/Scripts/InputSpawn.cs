using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSpawn : MonoBehaviour {

    [Header("Object to Spawn")]
    public GameObject spawnable;

    [Header("Player Object")]
    public GameObject player;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { 
            Debug.Log("Pressed primary button.");
            Vector3 temp = Input.mousePosition;
            temp.z = 10f; // Set this to be the distance you want the object to be placed in front of the camera.
            Object.Instantiate(spawnable, Camera.main.ScreenToWorldPoint(temp), transform.rotation);
         
        }
        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed secondary button.");

        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");

        if (Input.GetKeyDown(KeyCode.Escape))
            Cursor.lockState = CursorLockMode.None;

    }
}
