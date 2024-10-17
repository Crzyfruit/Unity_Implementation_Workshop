using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonBehaviour : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{


    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Up");
    }
}

#region
#if UNITY_EDITOR
[CustomEditor(typeof(ButtonBehaviour)), CanEditMultipleObjects]
public class CustomInspector : Editor
{
    public override void OnInspectorGUI()
    {
        Color boxColor = Color.white;
        boxColor.a = 0.1f;
        GUIStyle coloredBoxStyle = new GUIStyle(GUI.skin.box);
        coloredBoxStyle.normal.background = MakeTexture(2, 2, boxColor);
        GUI.skin.box = coloredBoxStyle;

        Color backgroundColor = Color.black;
        backgroundColor.a = 0.3f;

        Rect backgroundRect = new Rect(0, 0, 2000, 2000);
        EditorGUI.DrawRect(backgroundRect, backgroundColor);
        GUILayout.Space(10);

        EditorGUILayout.BeginHorizontal(GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
        EditorGUILayout.BeginVertical(coloredBoxStyle, GUILayout.ExpandHeight(true), GUILayout.ExpandWidth(true));
        GUILayout.Space(10);

        DrawDefaultInspector();
        GUILayout.Space(10);

        EditorGUILayout.EndHorizontal();
        GUILayout.Space(10);

        EditorGUILayout.EndVertical();
    }

    private Texture2D MakeTexture(int width, int height, Color col)
    {
        Color[] pix = new Color[width * height];
        for (int i = 0; i < pix.Length; i++)
        {
            pix[i] = col;
        }
        Texture2D result = new Texture2D(width, height);
        result.SetPixels(pix);
        result.Apply();
        return result;
    }
}
#endif
#endregion