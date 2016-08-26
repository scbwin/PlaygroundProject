﻿using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(ConsumeResourceAction))]
public class ConsumeResourceActionInspector : ConditionInspectorBase
{
	private string explanation = "Use this script to check if the player has a specific resource. If he has it, it will be consumed and the action below will happen.";

	public override void OnInspectorGUI()
	{
		GUILayout.Space(10);
		EditorGUILayout.HelpBox(explanation, MessageType.Info);

		GUILayout.Space(10);
		EditorGUILayout.PropertyField(serializedObject.FindProperty("happenOnlyOnce"));
		EditorGUILayout.PropertyField(serializedObject.FindProperty("checkFor"));
		EditorGUILayout.PropertyField(serializedObject.FindProperty("amountNeeded"));

		GUILayout.Space(10);
		DrawActionLists();

		serializedObject.ApplyModifiedProperties();
	}
}