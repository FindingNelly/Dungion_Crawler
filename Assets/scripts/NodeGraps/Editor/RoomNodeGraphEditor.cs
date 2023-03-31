using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RoomNodeGraphEditor : EditorWindow
{

    private GUIStyle roomNodeStyle;

    
    private const float nodeHight = 160;
    private const float nodeWidth = 75;
    private const int nodePading = 25;
    private const int nodeBorder = 12;
    
    [MenuItem("Room Graph Editor", menuItem = "Window/Dungeon Editor/Room Node Graph Editor")]
    
  private static void OpenWindow()
  {
      GetWindow<RoomNodeGraphEditor>("Room Node Graph Editor");
  }


  private void OnEnable()
  {
      roomNodeStyle = new GUIStyle();
      roomNodeStyle.normal.background=EditorGUIUtility.Load("node1") as Texture2D;
      roomNodeStyle.normal.textColor = Color.white;
      roomNodeStyle.padding = new RectOffset(nodePading, nodePading, nodePading, nodePading);
      roomNodeStyle.border = new RectOffset(nodeBorder, nodeBorder, nodeBorder, nodeBorder);

  }

  private void OnGUI()
  {
    GUILayout.BeginArea(new Rect(new Vector2(100f,100f), new Vector2(nodeHight,nodeWidth)),roomNodeStyle);
    EditorGUILayout.LabelField("Node 1");
    GUILayout.EndArea();
    
    GUILayout.BeginArea(new Rect(new Vector2(100f,300f), new Vector2(nodeHight,nodeWidth)),roomNodeStyle);
    EditorGUILayout.LabelField("Node 1");
    GUILayout.EndArea();
  }
}
