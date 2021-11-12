using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace U.Gears.Editor
{
    [CanEditMultipleObjects]
    [CustomEditor(typeof(DisableGameObject))]
    public class DisableGameObjectCustomInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {

            DisableGameObject c = (DisableGameObject)target;

            GUILayout.Space(8);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("scriptName"), true);
            GUILayout.Space(5);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("disableOnAwake"), true);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("disableOnStart"), true);
            GUILayout.Space(5);
            EditorGUILayout.PropertyField(serializedObject.FindProperty("cArray"), true);

            serializedObject.ApplyModifiedProperties();

        }
    }
}
