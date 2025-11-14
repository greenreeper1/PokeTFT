using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class HexMesh : MonoBehaviour
{
    public float radius = 1f;
    public float height = 0.05f;


    private void Awake()
    {
        Debug.Log(gameObject.name);
        GetComponent<MeshFilter>().mesh = CreateHexMesh(radius, height);
    }

    Mesh CreateHexMesh(float radius, float height)
    {
        Mesh mesh = new Mesh();

        // Vertices (top & bottom)
        Vector3[] vertices = new Vector3[12];
        for (int i = 0; i < 6; i++)
        {
            float angle = Mathf.Deg2Rad * (60 * i);
            float x = Mathf.Cos(angle) * radius;
            float z = Mathf.Sin(angle) * radius;
            vertices[i] = new Vector3(x, height / 2f, z); // top
            vertices[i + 6] = new Vector3(x, -height / 2f, z); // bottom
        }

        List<int> triangles = new List<int>();

        // Top face
        for (int i = 1; i < 5; i++)
        {
            triangles.Add(0);
            triangles.Add(i);
            triangles.Add(i + 1);
        }

        // Sides
        for (int i = 0; i < 6; i++)
        {
            int next = (i + 1) % 6;
            triangles.Add(i);
            triangles.Add(i + 6);
            triangles.Add(next);

            triangles.Add(next);
            triangles.Add(i + 6);
            triangles.Add(next + 6);
        }

        mesh.vertices = vertices;
        mesh.triangles = triangles.ToArray();
        mesh.RecalculateNormals();
        return mesh;
    }
}
