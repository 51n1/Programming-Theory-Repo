using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCube : MonoBehaviour
{
    [SerializeField]
    private Color cubeColor;

    public string cubeName = "Base Cube";

    void Start()
    {
        InitCube();
    }

    public virtual void InitCube()
    {
        GetComponent<MeshRenderer>().material.color = cubeColor;
        Debug.Log($"Name: {cubeName}");
    }
}
