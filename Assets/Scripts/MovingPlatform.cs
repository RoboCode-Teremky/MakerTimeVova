using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.back*speed*Time.deltaTime);
    }
}
