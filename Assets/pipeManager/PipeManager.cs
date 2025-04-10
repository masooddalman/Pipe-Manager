using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PipeManager : MonoBehaviour
{
    public int selectedIndex = -1;
    public List<GameObject> allPipePrefabs;
    public String[] allPipesNames () { 
        
        return allPipePrefabs.Select(item => item.name).ToArray<String>();
    }
}
