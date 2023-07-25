using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveForce;
    public Rigidbody rig;

    void FixedUpdate() // use this for Physics based system
        //runs at a fixed interval whereas Update runs per frame
        // FixedUpdate runs at 60 times per second
    {
        float xInput = Input.GetAxis("Horizontal");

        rig.AddForce(Vector3.right * xInput * moveForce);
    }
}
