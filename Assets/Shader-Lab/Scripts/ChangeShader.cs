using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeShader : MonoBehaviour
{
    [SerializeField] private Renderer meshRenderer;
    [SerializeField] private float expansionAmount;
    void Update()
    {
        meshRenderer.material.SetFloat("_PulseRate", expansionAmount);
    }
}
