using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyTowerD : MonoBehaviour
{
    [SerializeField] private int _price;
    [SerializeField] private GameObject _tower;
    [SerializeField] private GameObject[] _towerPlace;
    [SerializeField] private int _priceToBuy;
    private int _num;
    // Start is called before the first frame update
    void Start()
    {
        if (_num < 1 || _num > 5 || _num == null)
        {
            _num = 1;
        }
    }
    public void Buy()
    {
        if (PlayerPrefs.GetInt("moneyD") > _price)
        {
            PlayerPrefs.GetInt("numPlace");
            PlayerPrefs.SetInt("moneyD", PlayerPrefs.GetInt("money") - _priceToBuy);
            Instantiate(_tower, _towerPlace[_num].transform);
        }
    }
}
