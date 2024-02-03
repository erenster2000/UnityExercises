using UnityEngine;

namespace Runtime
{
    public static class Mathfs 
    {
        public const float TAU = 6.28318530717958f;
        
        public static Vector2 GetUnitVectorByAngle(float angRad)
        { return new Vector2(
                Mathf.Cos(angRad),
                Mathf.Sin(angRad)
            );
        }
    }
}