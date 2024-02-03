using System;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime
{
    [RequireComponent(typeof(MeshFilter))]
    public class DrawRing : MonoBehaviour
    {
        
        [Range(0.01f, 2)] 
        [SerializeField] private float innerRadius;
        [Range(0.01f, 2)] 
        [SerializeField] private float thickness;
        [Range(3, 32)] 
        [SerializeField] int angularSegmentCount = 3;

        private Mesh mesh;
        private float outerRadius => innerRadius + thickness;
        private int VertexCount => angularSegmentCount * 2;
        
        private void OnDrawGizmosSelected()
        {
            Gizmosfunc.DrawWireCircle(transform.position,transform.rotation,innerRadius,angularSegmentCount);
            Gizmosfunc.DrawWireCircle(transform.position,transform.rotation,outerRadius,angularSegmentCount);
            
        }

        private void Awake()
        {
            mesh = new Mesh();
            mesh.name = "QuadRing";
            GetComponent<MeshFilter>().sharedMesh = mesh;
        }

        private void Update()
        {
            GenerateMesh();
        }

        void GenerateMesh()
        {
            mesh.Clear();
            int vCount = VertexCount;

            List<Vector3> vertices = new List<Vector3>();

            for (int i = 0; i < angularSegmentCount; i++)
            {
                float t = i / (float)angularSegmentCount;
                float angRad = t * Mathfs.TAU;
                Vector2 point2d = Mathfs.GetUnitVectorByAngle(angRad);
                
                
            }


        }
        
        
        
    }
}