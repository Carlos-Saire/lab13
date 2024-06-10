using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalletControl : MonoBehaviour
{
    Rigidbody2D _Rigidbody2D;
    public float Velocity;
    private void Awake()
    {
        _Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        _Rigidbody2D.velocity=new Vector2(0,Velocity);
    }
}
