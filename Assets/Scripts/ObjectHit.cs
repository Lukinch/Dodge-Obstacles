using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{

    MeshRenderer meshRenderer;

    private void OnCollisionEnter(Collision other) {
        meshRenderer = GetComponent<MeshRenderer>();

        if (
            other.gameObject.tag == "Player" &&
            meshRenderer.material.color != Color.red
            )
        {
            meshRenderer.material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }

}