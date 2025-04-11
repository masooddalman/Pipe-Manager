using UnityEngine;
using UnityEditor;
using System.Collections.Generic;
using System;

[CustomEditor(typeof(PipeManager))]
public class PipeManagerEditor : Editor {

    [MenuItem("Assets/Create/New Pipe")]
    private static void CreateNewPipeSystem()
    {
        var g = new GameObject();
        g.transform.position = Vector3.zero;
        g.name = "PipeManager";
        var pm = g.AddComponent<PipeManager>();
        // get all pipe prefab from assets folder
        string folderPath = "Assets/pipeManager/pipeAssets/prefabs"; // the folder containing different parts of pipe network prefab
        string[] guids = AssetDatabase.FindAssets("t:Prefab", new[] { folderPath });
        List<GameObject> prefabs = new List<GameObject>();
        foreach (string guid in guids)
        {
            string assetPath = AssetDatabase.GUIDToAssetPath(guid);
            GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>(assetPath);
            if (prefab != null)
            {
                prefabs.Add(prefab);
            }
        }
        pm.allPipePrefabs = prefabs;
    }

    private int columns = 3;

    public override void OnInspectorGUI() {
        PipeManager pm = (PipeManager)target;
        serializedObject.Update ();

        
        //show grid of buttons
        GUILayout.Label("All pipe prefabs", EditorStyles.boldLabel);

        for (int i = 0; i < pm.allPipesNames().Length; i++)
        {
            if (i % columns == 0)
                GUILayout.BeginHorizontal();

            if (GUILayout.Button(pm.allPipesNames()[i], GUILayout.Width(100), GUILayout.Height(30)))
            {
                var pipe = Instantiate(pm.allPipePrefabs[i], pm.transform).GetComponent<Pipe>();
                if(pm.transform.childCount == 1 ) {
                    Debug.Log("first pip => zero position");
                    //first child at 0 position
                    pipe.transform.position = Vector3.zero;
                } else {
                    Debug.Log("pip manager pipe count : "+pm.transform.childCount);
                    //other children's start point should connect to the previous point
                    //get last chiled
                    var latestPipe = pm.transform.GetChild(pm.transform.childCount-2).GetComponent<Pipe>();
                    pipe.transform.position = latestPipe.end.position;
                    var lastPipeRotation = latestPipe.transform.rotation.eulerAngles;
                    lastPipeRotation.z -= pipe.ZRotation;
                    pipe.transform.rotation = Quaternion.Euler(lastPipeRotation);
                }
            }

            if (i % columns == columns - 1 || i == pm.allPipesNames().Length - 1)
                GUILayout.EndHorizontal();
        }
    }
}
