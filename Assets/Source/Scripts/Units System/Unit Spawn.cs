using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UI.CanvasScaler;

public class UnitSpawn : MonoBehaviour
{
    [SerializeField] GameObject Unit;
    [SerializeField] Transform Spawnpoint;
//    public Vector2 pos = Spawnpoint.transform.position;

    public void Spawn()
    {
        Instantiate(Unit, Spawnpoint);
    }
}
