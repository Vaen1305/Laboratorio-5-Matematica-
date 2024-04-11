using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CoordinatesController : MonoBehaviour
{
    public float gizmoSize = 0.75f;
    public float gizmoDistance = 0.02f;


    void OnDrawGizmos()
    {
        Gizmos.matrix = transform.localToWorldMatrix;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, Vector3.right * gizmoSize);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, Vector3.left * gizmoSize);

        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, Vector3.up * gizmoSize);
        Gizmos.color = Color.green;
        Gizmos.DrawLine(Vector3.zero, Vector3.down * gizmoSize);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Vector3.zero, Vector3.forward * gizmoSize);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Vector3.zero, Vector3.back * gizmoSize);

        GUIStyle style = new GUIStyle();
        style.normal.textColor = Color.red;
        Handles.Label(transform.position + Vector3.right * (gizmoSize + gizmoDistance), "+X", style);
        Handles.Label(transform.position + Vector3.left * (gizmoSize + gizmoDistance), "-X", style);

        style.normal.textColor = Color.green;
        Handles.Label(transform.position + Vector3.up * (gizmoSize + gizmoDistance), "+Y", style);
        Handles.Label(transform.position + Vector3.down * (gizmoSize + gizmoDistance), "-Y", style);

        style.normal.textColor = Color.blue;
        Handles.Label(transform.position + Vector3.forward * (gizmoSize + gizmoDistance), "+Z", style);
        Handles.Label(transform.position + Vector3.back * (gizmoSize + gizmoDistance), "-Z", style);
    }
}
