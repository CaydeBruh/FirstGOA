using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptScale : MonoBehaviour
{

    void Update()
    {
        transform.localScale = this.transform.localScale + new Vector3(0.25f, 0.25f, 0.25f) * Time.deltaTime;
    }
}
