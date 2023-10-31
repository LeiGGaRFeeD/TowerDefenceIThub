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
    void Update()
    {
        Debug.Log("Update is working");
        Debug.Log("MoneyD = "+ PlayerPrefs.GetInt("moneyD"));

        if (PlayerPrefs.GetInt("moneyD") > _price)
        {
            if (Input.GetKeyUp(KeyCode.Alpha1))
            {
            Debug.Log("Clicked first button");
                PlayerPrefs.SetInt("moneyD", PlayerPrefs.GetInt("money") - _priceToBuy);
                Instantiate(_tower, _towerPlace[0].transform);
            }
            if (Input.GetKeyUp(KeyCode.Alpha2))
            {
                PlayerPrefs.SetInt("moneyD", PlayerPrefs.GetInt("money") - _priceToBuy);
                Instantiate(_tower, _towerPlace[1].transform);
            }
            if (Input.GetKeyUp(KeyCode.Alpha3))
            {
                PlayerPrefs.SetInt("moneyD", PlayerPrefs.GetInt("money") - _priceToBuy);
                Instantiate(_tower, _towerPlace[2].transform);
            }
            if (Input.GetKeyUp(KeyCode.Alpha4))
            {
                PlayerPrefs.SetInt("moneyD", PlayerPrefs.GetInt("money") - _priceToBuy);
                Instantiate(_tower, _towerPlace[3].transform);
            }
        }
    }
}
