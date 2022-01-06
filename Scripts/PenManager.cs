using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool drawingOnSurface = false;

    public void DrawOnSurface()
    {
        drawingOnSurface = true;
    }

    public void DrawInSpace()
    {
        drawingOnSurface = false;
    }
}
