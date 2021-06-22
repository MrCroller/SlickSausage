using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SausageCS : MonoBehaviour
{
    private Rigidbody _sausageRB;

    void Awake()
    {
        _sausageRB = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _sausageRB.AddForce(0, 60, 60);
        }
    }

}
