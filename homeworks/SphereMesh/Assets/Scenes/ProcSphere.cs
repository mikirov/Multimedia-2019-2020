﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class ProcSphere : MonoBehaviour
{

    private Mesh mesh;
    private Vector3[] vertices;

    public int horizontalLines, verticalLines;
    public int radius;

    private void Awake()
    {
        GetComponent<MeshFilter>().mesh = mesh = new Mesh();
        mesh.name = "sphere";
        vertices = new Vector3[horizontalLines * verticalLines];
        int index = 0;
        for (int m = 0; m < horizontalLines; m++)
        {
            for (int n = 0; n < verticalLines - 1; n++)
            {
                float x = Mathf.Sin(Mathf.PI * m / horizontalLines) * Mathf.Cos(2 * Mathf.PI * n / verticalLines);
                float y = Mathf.Sin(Mathf.PI * m / horizontalLines) * Mathf.Sin(2 * Mathf.PI * n / verticalLines);
                float z = Mathf.Cos(Mathf.PI * m / horizontalLines);
                vertices[index++] = new Vector3(x, y, z) * radius;
            }
        }
        mesh.vertices = vertices;
    }

    private void OnDrawGizmos()
    {
        if (vertices == null)
        {
            return;
        }
        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.color = Color.black;
            Gizmos.DrawSphere(transform.TransformPoint(vertices[i]), 0.1f);
        }
    }
}