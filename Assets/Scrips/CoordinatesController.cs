using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CoordinatesController : MonoBehaviour
{
    public float lineLength = 1.0f; 

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, Vector3.right * lineLength);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, Vector3.up * lineLength);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Vector3.zero, Vector3.forward * lineLength);
    }
}
