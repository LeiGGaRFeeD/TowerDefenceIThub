using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.UI.CanvasScaler;

public enum UnitType
{
    Runer = 1,
    Flyer = 2,
    Shooter = 3
}

public class UnitSpawn : MonoBehaviour
{
    // ��������!!!!
    public MoneySouls souls;
    public UnitType _unitType;
    private int price;
    void Start()
    {
        if (_unitType == UnitType.Runer)
        {
            price = 10;
        }
        if (_unitType == UnitType.Flyer)
        {
            price = 30;
        }
        if (_unitType == UnitType.Shooter)
        {
            price = 50;
        }
    }
    public void Spawn(GameObject UnitPrefab)
    {
        if (price <= souls.Souls)
        {
            if (PlayerPrefs.GetInt("onScreen")<8){
                GameObject unit = Instantiate(UnitPrefab);
                unit.transform.position = transform.position;
                souls.Souls -= price;
            }
        }
    }
}
