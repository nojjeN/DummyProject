using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddForce(0, 200, 0);
    }
}
