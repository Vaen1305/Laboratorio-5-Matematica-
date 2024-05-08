using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSphere : MonoBehaviour
{
    public Vector3 translation = Vector3.zero;
    public Vector3 scale = Vector3.one;
    public float sphereRadius = 0.5f;
    public int vertex = 256;

    void OnDrawGizmos()
    {
        int resolution = Mathf.RoundToInt(Mathf.Sqrt(vertex));
        Vector3[] vertices = new Vector3[(resolution + 1) * resolution];

        for (int i = 0; i <= resolution; ++i)
        {
            float y = Mathf.Cos((float)i / resolution * Mathf.PI);
            float radius = Mathf.Sqrt(1 - y * y);

            for (int j = 0; j < resolution; ++j)
            {
                float x = Mathf.Cos((float)j / resolution * 2 * Mathf.PI) * radius;
                float z = Mathf.Sin((float)j / resolution * 2 * Mathf.PI) * radius;

                Vector3 vertex = new Vector3(x, y, z);
                vertex += translation;
                vertex = Vector3.Scale(vertex, scale);
                vertices[i * resolution + j] = vertex;
            }
        }

        for (int i = 0; i < vertices.Length; ++i)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(vertices[i], sphereRadius / resolution);
        }

        Gizmos.color = Color.white;
        DrawLine(vertices, resolution);
    }

    void DrawLine(Vector3[] vertices, int resolution)
    {
        for (int i = 0; i <= resolution; ++i)
        {
            for (int j = 0; j < resolution; ++j)
            {
                Vector3 current = vertices[i * resolution + j];
                if (j < resolution - 1)
                {
                    Vector3 next = vertices[i * resolution + j + 1];
                    Gizmos.DrawLine(current, next);
                }
                else
                {
                    Vector3 next = vertices[i * resolution];
                    Gizmos.DrawLine(current, next);
                }
                if (i < resolution)
                {
                    Vector3 below = vertices[(i + 1) * resolution + j];
                    Gizmos.DrawLine(current, below);
                }
            }
        }
    }
}
