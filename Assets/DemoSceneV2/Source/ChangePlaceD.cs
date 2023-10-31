using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlaceD : MonoBehaviour
{
    private int _place;
    public void PlaceOme()
    {
        PlayerPrefs.SetInt("Place", 1);
    }
    public void PlaceTwo()
    {
        PlayerPrefs.SetInt("Place", 2);
    }
    public void PlaceThree()
    {
        PlayerPrefs.SetInt("Place", 3);
    }
    public void PlaceFour()
    {
        PlayerPrefs.SetInt("Place", 4);
    }
}
