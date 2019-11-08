using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    public GameManager gameManager; 
    
    public float velocity = 1;
    public float rotationSmooth = 5;

    Rigidbody2D rb;
    Quaternion downRot;
    Quaternion upRot;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        downRot = Quaternion.Euler(0, 0, -80);
        upRot = Quaternion.Euler(0, 0, 40);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
            transform.rotation = upRot;
        }

        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            downRot,
            rotationSmooth * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        gameManager.GameOver();
    }
}
