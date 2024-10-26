using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BetterDebug
{
    public static void Log(object message)
    {
        string debugColor = $"<color=cyan>";
        string closeColor = "</color>";

        Debug.Log($"{debugColor}{message}{closeColor}");
    }

    public static void Log(object message, string color)
    {
        string debugColor = $"<color={color}>";
        string closeColor = "</color>";

        Debug.Log($"{debugColor}{message}{closeColor}");
    }

    public static void Log(object message, Object context)
    {
        Debug.Log(message, context);
    }
}