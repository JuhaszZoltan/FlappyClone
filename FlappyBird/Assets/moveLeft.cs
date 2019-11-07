using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    public float speed = 1;
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
