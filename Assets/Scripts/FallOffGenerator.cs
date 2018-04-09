using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class FallOffGenerator {

    public static float[,] GenerateFallOffMap(int width, int height)
    {
        float[,] map = new float[width, height];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                float x = i / (float)height * 2 - 1;
                float y = j / (float)width * 2 - 1;

                float value = Mathf.Max (Mathf.Abs(x), Mathf.Abs(y));
                map[i, j] = Evaluate(value);
            }
        }

        return map;
    }

    static float Evaluate(float value)
    {
        float a = 3;
        float b = 2.6f;
        return Mathf.Pow(value, a) / (Mathf.Pow(value, a) + Mathf.Pow(b - b * value, a));
    }

}
