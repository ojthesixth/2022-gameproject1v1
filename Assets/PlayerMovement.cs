using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody _rigidbodyp;
    public float _speed = 10f;
    public GameObject bullet;
// public float _rotation;

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("bonk");
    }

   void Start() { }


 void Update()

    { if (Input.GetButtonDown("Jump")) 
            for (var i = 0; i < 10; i++) {
                GameObject o = Instantiate(bullet); }
    

        float v = Input.GetAxis("Vertical") * _speed;
        float r = Input.GetAxis("Horizontal") * _speed;
        _rigidbodyp.velocity = new Vector3(r, 0, v);
     }}