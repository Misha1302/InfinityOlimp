using UnityEngine;

namespace Sharp
{
    public static class Vector2Extensions
    {
        public static Vector2 WithX(this Vector2 vector, float x) => new(x, vector.y);

        public static Vector2 WithY(this Vector2 vector, float y) => new(vector.x, y);
    }
}