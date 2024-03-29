﻿using UnityEngine;

public class Transfer : MonoBehaviour
{
    [Range(0f, 1f)]
    public float Value;

    public Transform Cube1;
    public Transform Cube2;

    public Material Material1;
    public Material Material2;
    public Material Material3;

    private void Update()
    {
        transform.position = Vector3.Lerp(Cube1.position, Cube2.position, Value);
        transform.localScale = Vector3.Lerp(Cube1.localScale, Cube2.localScale, Value);
        Material3.color = Color.Lerp(Material1.color, Material2.color, Value);
    }
}
