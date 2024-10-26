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
        string debugColor = $"<b><color={color}>";
        string emoji = $" <color={color}>\u2665</color>";
        string closeColor = "</color></b>";

        Debug.Log($"{debugColor}{message}{closeColor}{emoji}");
    }

    public static void Log(object message, Object context)
    {
        Debug.Log(message, context);
    }
}