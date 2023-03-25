using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    void Start()
    {
        public float speed = 9;

    }

    void Update()
    {
        transform.Translate(Time.deltaTime * 7,0,0);
    }
}
