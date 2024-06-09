using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObs : Bonus
{
    [SerializeField] private float speed=1.0f;
    [Range(0.0f, 2*Mathf.PI)][SerializeField] private float phase = 0.0f;
    [SerializeField] Transform leftEdge, rightEdge;
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position = Vector3.Lerp(leftEdge.position, rightEdge.position, Mathf.Sin(speed*Time.timeSinceLevelLoad+phase)/2.0f+0.5f);
        transform.rotation = Quaternion.Euler(0.0f,speed*Time.timeSinceLevelLoad,0.0f);
    }
}