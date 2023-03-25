using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Controller : MonoBehaviour
{
    void Start()
    {
        public float speed = 9;

    }

    void Update()
    {
        transform.Translate(Time.deltaTime * speed ,0,0);
    }
}
