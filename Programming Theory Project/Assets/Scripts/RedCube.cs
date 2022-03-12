using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class RedCube : BaseCube
{
    // POLYMORPHISM
    public override void InitCube()
    {
        base.InitCube();
        transform.Translate(Vector3.up);
    }
}
