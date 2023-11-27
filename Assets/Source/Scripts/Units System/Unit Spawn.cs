using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UI.CanvasScaler;

public class UnitSpawn : MonoBehaviour
{
    // ƒŒœ»—¿“‹!!!!
    MoneySouls souls;
    private void Start()
    {
        souls = GameObject.FindGameObjectWithTag("MoneySoulsManager").GetComponent<MoneySouls>();
    }
    public void Spawn(GameObject UnitPrefab)
    {
        GameObject unit = Instantiate(UnitPrefab);
        unit.transform.position = transform.position;
    }
}
