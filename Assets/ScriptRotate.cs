using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptRotate : MonoBehaviour
{

    // Start is called before the first frame update
    void Update()
    {
        Vector3 rotationToAdd = new Vector3(0, 45, 0);
        transform.Rotate(rotationToAdd);
    }

    
}
