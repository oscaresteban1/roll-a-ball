using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        Vector3 movecamera = new Vector3(0f, -Input.mouseScrollDelta.y, Input.mouseScrollDelta.y);
        float dist = offset.sqrMagnitude;

        if(!(dist <= 20 && Input.mouseScrollDelta.y == 1 || dist >= 300 && Input.mouseScrollDelta.y == -1))
            offset += movecamera;
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
