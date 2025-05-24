using System;
using UnityEditor;
using UnityEngine;

namespace MFramework.EditorExtensions
{
    public static class EditorGUIDrawer
    {
        #region LinkButton

        public static void DrawLinkButton(GUIContent content, string url, params GUILayoutOption[] options)
        {
            if (GUILayout.Button(content, options)) Application.OpenURL(url);
        }

        public static void DrawLinkButton(GUIContent content, GUIStyle style, string url,
            params GUILayoutOption[] options)
        {
            if (GUILayout.Button(content, style, options)) Application.OpenURL(url);
        }

        public static void DrawLinkButton(string label, string url, params GUILayoutOption[] options)
        {
            if (GUILayout.Button(label, options)) Application.OpenURL(url);
        }

        public static void DrawLinkButton(Texture texture, GUIStyle style, string url, params GUILayoutOption[] options)
        {
            if (GUILayout.Button(texture, style, options)) Application.OpenURL(url);
        }

        public static void DrawLinkButton(Texture texture, string url, params GUILayoutOption[] options)
        {
            if (GUILayout.Button(texture, options)) Application.OpenURL(url);
        }

        public static void DrawLinkButton(string label, GUIStyle style, string url, params GUILayoutOption[] options)
        {
            if (GUILayout.Button(label, options)) Application.OpenURL(url);
        }

        public static void DrawLink(string link, Action onClick = null, params GUILayoutOption[] options)
        {
            GUILayout.BeginHorizontal(options);
            {
                EditorGUILayout.LabelField(link, EditorGUIStyles.linkStyle);
                var linkRect = GUILayoutUtility.GetLastRect();
                EditorGUIUtility.AddCursorRect(linkRect, MouseCursor.Link);
                if (Event.current.type == EventType.MouseDown && linkRect.Contains(Event.current.mousePosition))
                {
                    if (onClick != null) onClick.Invoke();
                    else Application.OpenURL(link);
                    Event.current.Use();
                }
            }
            EditorGUILayout.EndHorizontal();
        }

        #endregion
        
        #region Lines

        public static Rect DrawHorizontalLine(Color color, int thickness = 1, int padding = 5)
        {
            var lineRect = EditorGUILayout.GetControlRect(false, thickness + padding);
            lineRect.height = thickness;
            lineRect.y += padding * 0.5f;
            EditorGUI.DrawRect(lineRect, color);
            return lineRect;
        }

        public static Rect DrawVerticalLine(Color color, int thickness = 1, int padding = 5)
        {
            var lineRect = EditorGUILayout.GetControlRect(false, thickness + padding);
            lineRect.width = thickness;
            lineRect.x += padding * 0.5f;
            EditorGUI.DrawRect(lineRect, color);
            return lineRect;
        }

        public static Rect DrawVerticalSeparator(Vector2 size, Color color)
        {
            var rect = GUILayoutUtility.GetLastRect();
            rect.x += rect.width;
            rect.width = size.x;
            rect.height = size.y;
            EditorGUI.DrawRect(rect, color);
            return rect;
        }

        public static Rect DrawHorizontalSeparator(Vector2 size, Color color)
        {
            var rect = GUILayoutUtility.GetLastRect();
            rect.y += rect.height;
            rect.height = size.y;
            rect.width = size.x;
            EditorGUI.DrawRect(rect, color);
            return rect;
        }

        #endregion

        public static Rect DrawRectArea(Vector2 position, Vector2 size, Color fillColor, Color outlineColor,
            int outlineWidth, System.Action drawing = null)
        {
            var rect = new Rect(position, size);
            EditorGUI.DrawRect(rect, fillColor);
            rect.DrawOutline(outlineColor, outlineWidth);
            GUILayout.BeginArea(rect);
            drawing?.Invoke();
            GUILayout.EndArea();
            return rect;
        }
    }
}