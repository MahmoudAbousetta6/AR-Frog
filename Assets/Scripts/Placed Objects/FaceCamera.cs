using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    [SerializeField] private Transform target = null;

    private void Start()
    {
        target = Camera.main.transform;
    }
    void Update()
    {
        transform.position = target.position;

      /*  Quaternion r1 = Quaternion.LookRotation(transform.position - target.position, Vector3.up);
        Vector3 euler2 = transform.eulerAngles;
        transform.rotation = Quaternion.Euler(euler2.x, r1.eulerAngles.y, euler2.z);*/
    }
}
