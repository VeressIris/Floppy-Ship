using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    private float speed = 25f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
