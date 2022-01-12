using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float rotateY = 1f;
    [SerializeField] float rotateZ = 0f;
    [SerializeField] float rotateX = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateX,rotateY,rotateZ);
    }
}
