using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faller : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    [SerializeField] int elapsedTime = 3;

    private void Start() {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
        rigidBody.constraints =
            RigidbodyConstraints.FreezeRotationX |
            RigidbodyConstraints.FreezeRotationY |
            RigidbodyConstraints.FreezeRotationZ |
            RigidbodyConstraints.FreezePositionX |
            RigidbodyConstraints.FreezePositionZ ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= elapsedTime)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.name == "Ground")
        {
            Debug.Log("Freezed position");
            rigidBody.constraints =
                RigidbodyConstraints.FreezePositionY |
                RigidbodyConstraints.FreezeRotationX |
                RigidbodyConstraints.FreezeRotationY |
                RigidbodyConstraints.FreezeRotationZ |
                RigidbodyConstraints.FreezePositionX |
                RigidbodyConstraints.FreezePositionZ ;;
        }
    }
}
