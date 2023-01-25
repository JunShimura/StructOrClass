using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class DestoryTtest : MonoBehaviour
{
    Rigidbody rigidbody;
    Boolean clicked =false;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        clicked = Input.GetMouseButton(1);
    }
    private void FixedUpdate()
    {
        if (clicked)
        {
            rigidbody.MovePosition(this.transform.position+transform.right/5);
            clicked= false;
        }
    }
}
