using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMo : MonoBehaviour
{
    public Vector3 offset;
    public Transform target;
    public float speed = 5f;
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, speed);
    }
}
