using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCube : MonoBehaviour
{
    public Vector3 translation = Vector3.zero;
    public Vector3 scale = Vector3.one;
    public float sphereRadius = 0.1f;

    void OnDrawGizmos()
    {
        Vector3[] originalVertices = {
            new Vector3(-0.5f, -0.5f, -0.5f),
            new Vector3(0.5f, -0.5f, -0.5f),
            new Vector3(0.5f, 0.5f, -0.5f),
            new Vector3(-0.5f, 0.5f, -0.5f),
            new Vector3(-0.5f, -0.5f, 0.5f),
            new Vector3(0.5f, -0.5f, 0.5f),
            new Vector3(0.5f, 0.5f, 0.5f),
            new Vector3(-0.5f, 0.5f, 0.5f)
        };

        for (int i = 0; i < originalVertices.Length; i++)
        {
            originalVertices[i] += translation;
        }

        for (int i = 0; i < originalVertices.Length; i++)
        {
            originalVertices[i] = Vector3.Scale(originalVertices[i], scale);
        }
        for (int i = 0; i < originalVertices.Length; i++)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(originalVertices[i], sphereRadius);
        }
        DrawLines(originalVertices);
    }

    void DrawLines(Vector3[] vertices)
    {
        DrawLine(vertices[0], vertices[1]);
        DrawLine(vertices[1], vertices[2]);
        DrawLine(vertices[2], vertices[3]);
        DrawLine(vertices[3], vertices[0]);

        DrawLine(vertices[4], vertices[5]);
        DrawLine(vertices[5], vertices[6]);
        DrawLine(vertices[6], vertices[7]);
        DrawLine(vertices[7], vertices[4]);

        DrawLine(vertices[0], vertices[4]);
        DrawLine(vertices[1], vertices[5]);
        DrawLine(vertices[2], vertices[6]);
        DrawLine(vertices[3], vertices[7]);
    }

    void DrawLine(Vector3 point1, Vector3 point2)
    {
        Gizmos.DrawLine(point1, point2);
    }
}
