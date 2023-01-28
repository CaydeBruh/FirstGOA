using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScriptMove : MonoBehaviour
{
    void Update()
    {
            transform.Translate(0, 0, Time.deltaTime);

            transform.Translate(0, Time.deltaTime, 0, Space.World);

        Vector3 originalPos = gameObject.transform.position;

        for(int i = 0; i < 5; i++)
        {
            gameObject.transform.position = originalPos;
        }
    }
}
