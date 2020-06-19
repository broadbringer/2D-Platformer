using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Borders : MonoBehaviour
{
    public Vector3 MaxScreenBounds { get; private set; }
    public Vector3 MinScreenBounds { get; private set; }
    private void Awake()
    {
        MaxScreenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        MinScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.transform.position.z));
    }
    
}
