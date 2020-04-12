using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    private float starty;
    private float amplitude;

    void Start()
    {
        starty = transform.position.y;
        amplitude = 0.15f;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 30) * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, starty + amplitude * Mathf.Sin(Time.time), transform.position.z);
    }
}
