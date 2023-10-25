using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEBUG_DemoV2 : MonoBehaviour
{
    [SerializeField] private bool _debugIsOn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_debugIsOn == true)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                PlayerPrefs.SetInt("healthD", 100);
                Debug.Log("Health reseted!");
                Debug.Log("Health: " + PlayerPrefs.GetInt("healthD").ToString());
            }
        }
    }
}
