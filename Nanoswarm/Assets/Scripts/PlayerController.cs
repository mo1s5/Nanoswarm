using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float speedX;
    float speedY;
    public float Speed;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.Translate(speedX * Time.deltaTime,0,0);
        transform.Translate(0,speedY * Time.deltaTime,0);
    }
    public void RightButtonDown()
    {
        speedX = Speed;
    }
    public void LeftButtonDown()
    {
        speedX = -Speed;
    }
    public void UpButtonDown()
    {
        speedY = -Speed;
    }
    public void DownButtonDown()
    {
        speedY = Speed;
    }
    public void Stop()
    {
        speedX = 0;
        speedY = 0;
    }
}
