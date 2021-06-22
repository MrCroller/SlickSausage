using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform sausage;

    private bool _flag = false;

    void FixedUpdate()
    {
        if (_flag) LookS();
    }

    void LookS()
    {
        transform.LookAt(sausage);

    }

    public void EndAnim()
    {
        _flag = true;
    }
}
