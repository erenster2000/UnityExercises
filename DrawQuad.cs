using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawQuad : MonoBehaviour
{
    private void Awake()
    {
        Mesh mesh = new Mesh();
        mesh.name = "Prodecural Quad";

        List<Vector3> points = new List<Vector3>()
        {
            new Vector3(-1,1),
            
            new Vector3(1,1),
            
            new Vector3(-1,-1),
            
            new Vector3(1,-1)
            
        };

        List<Vector3> normals = new List<Vector3>()
        {
            new Vector3(0, 0, 1),

            new Vector3(0, 0, 1),

            new Vector3(0, 0, 1),

            new Vector3(0, 0, 1),
        };

        List<Vector2> uvs = new List<Vector2>()
        {
            new Vector2(1,1),
            
            new Vector2(0,1),
            
            new Vector2(1,0),
            
            new Vector2(0,0),
            
        };
        
        int[] triIndices = new int[]
        {
            1,0,2,
            3,1,2
        };
        
        mesh.SetVertices(points);
        mesh.triangles = triIndices;
        mesh.SetNormals(normals);

        GetComponent<MeshFilter>().sharedMesh = mesh;

    }
    
    
}
