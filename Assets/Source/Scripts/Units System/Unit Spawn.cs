using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UI.CanvasScaler;

public class UnitSpawn : MonoBehaviour
{
    public void Spawn(GameObject UnitPrefab)
    {
        GameObject unit = Instantiate(UnitPrefab);
        unit.transform.position = transform.position;
    }
}
