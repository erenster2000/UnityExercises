using UnityEngine;

namespace Runtime
{
    public static class Gizmosfunc 
    {
        
        
        
        public static void DrawWireCircle(Vector3 pos, Quaternion rot, float radius ,int detail = 32 )
        {
            Vector3[] points3d = new Vector3[detail];
            for (int i = 0; i < detail; i++)
            {
                float t = i / (float)detail;
                float angRad = t * Mathfs.TAU;
                Vector2 point2d = Mathfs.GetUnitVectorByAngle(angRad);
                points3d[i] = pos + rot * point2d;
            }
            //draw dots
            for (int i = 0; i < detail-1; i++)
            {
                Gizmos.DrawLine( points3d[i], points3d[i+1]);
            }
            Gizmos.DrawLine( points3d[detail-1], points3d[0]);

        }
        
        
    }
}