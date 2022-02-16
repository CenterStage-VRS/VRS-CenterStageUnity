using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GoalZoneTapeMaker))]
public class GoalZoneTapeMakerCustomEditor : Editor
{
    private void OnEnable()
    {
    }

    public override void OnInspectorGUI()
    {
        EditorStyles.label.wordWrap = true;
        EditorGUILayout.LabelField("This component will automatically generate tape around a goal zone cube, thus making the tape placement exact to the collider. It requires that the floor collider object have a tag of 'Floor' to function.");
        EditorGUILayout.Space();
        EditorGUILayout.Space();


        base.OnInspectorGUI();


    }
}