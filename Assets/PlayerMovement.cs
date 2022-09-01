using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody _rigidbodyp;
    public float _speed = 10f;
    public GameObject bulletfile;
   // public GameObject _bulletPrefab;
    public GameObject _bullet;
    // public float _rotation;

    /*
    private void FireBullet()
    {
        GameObject bullet = Instantiate(_bullet);
    }

     void Update OnCollisionEnter(Collision col)
     {
         Debug.Log("bonk");
     }
   */

    void Start() { }


    void Update()

    {
        if (Input.GetButtonDown("Jump"))
      //  { FireBullet(); }
        for (var i = 0; i < 1; i++)
        {
            GameObject o = Instantiate(_bullet, bulletfile.transform.position, _bullet.transform.localRotation );
        }

        float v = Input.GetAxis("Vertical") * _speed;
        float r = Input.GetAxis("Horizontal") * _speed;
        _rigidbodyp.velocity = new Vector3(r, 0, v);
    }
}