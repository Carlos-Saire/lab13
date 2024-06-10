using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    public GameObject _gameObject;
    public GameObject _spawnPoint;
    public float Speed;
    float horizontal;
    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Instantiate(_gameObject, _spawnPoint.transform.position, transform.rotation);
        }
    }
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        _rigidbody2D.velocity = new Vector2(horizontal * Speed, 0);
    }

}
