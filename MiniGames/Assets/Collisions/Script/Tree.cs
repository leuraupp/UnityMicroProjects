using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public Color hitCollor;
    public MeshRenderer mr;

    private void OnCollisionEnter(Collision collision) {
        mr.material.color = hitCollor;
    }
}
