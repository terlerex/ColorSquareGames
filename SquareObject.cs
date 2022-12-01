using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


[CreateAssetMenu(fileName = "New Square", menuName = "Square")]
public class SquareObject : ScriptableObject
{
    public List<Color> lstColor;
    public List<Vector3> lstPosition;

    public string prefabName;
    public int numberOfPrefabsToCreate;
}
