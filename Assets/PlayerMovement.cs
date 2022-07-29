using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody _rigidbodyp;
    public float _speed = 10f;
    public GameObject projectile; }
// public float _rotation;

// Start is called before the first frame update

    void Start() { }

// Update is called once per frame
    void Update()
    {
    if (Input.GetButtonDown("Jump")) {
        for (var i = 0; i < 10; i++)
            object.Instantiate(projectile); }


        float v = Input.GetAxis("Vertical") * _speed;
        float r = Input.GetAxis("Horizontal") * _speed;
        _rigidbodyp.velocity = new Vector3(r, 0, v);
    }