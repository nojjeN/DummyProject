using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinSphere : MonoBehaviour
{
    public Transform sphere;
    Vector3 point;

    private void Awake()
    {
        point = new Vector3(0, 0, 4);
        sphere = GetComponent<Transform>();
    }


    float angle = 0;
    float speed = 5;
    float radius = 10;
    void Update()
    {
        angle += speed * Time.deltaTime; //if you want to switch direction, use -= instead of +=
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;
        sphere.position = point + new Vector3(x, 0, z);
    }
}
