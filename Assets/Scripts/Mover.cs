using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;

    // int hitPoints = 100;
    [SerializeField] float yBaseSpeed = 0.00f;

    // Update is called once per frame
    void Update()
    {

        float xValue = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float zValue = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;

        transform.Translate( xValue , yBaseSpeed , zValue );
    }
}
