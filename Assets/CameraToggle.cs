using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello world!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Camera cam = GameObject.Find("Phone Camera").GetComponent<Camera>();
            cam.cullingMask = cam.cullingMask ^ (1 << 6);
        }
    }
}
