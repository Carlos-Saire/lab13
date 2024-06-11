using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    AudioSource _Audio;
    Rigidbody2D _rigidbody2D;
    public GameObject _gameObject;
    public GameObject _spawnPoint;
    public float Speed;
    float horizontal;
    float vertical;
    private void Awake()
    {
        _Audio = GetComponent<AudioSource>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            _Audio.Play();
            Instantiate(_gameObject, _spawnPoint.transform.position, transform.rotation);

        }
    }
    void FixedUpdate()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        _rigidbody2D.velocity = new Vector2(horizontal * Speed, vertical*Speed);
    }

}
