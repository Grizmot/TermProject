using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject target;

    // Start is called before the first frame update
    private void Awake()
    {
        transform.position = target.transform.position
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = target.transform.position
    }
}
