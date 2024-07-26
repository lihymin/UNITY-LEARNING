using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal") * 3, rigid.velocity.y, Input.GetAxisRaw("Vertical") * 3);
        rigid.velocity = vec;

        if(Input.GetButtonDown("Jump")){
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.name == "JumpEffect")
        {
            rigid.AddForce(Vector3.up * 0.7f, ForceMode.Impulse);
        }
    }
}

