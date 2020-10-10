using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInventory : MonoBehaviour
{
    private Canvas test;
    private void Start()
    {
        test = GetComponent<Canvas>();
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.I))
        {
            test.enabled = !test.enabled;

        } 
    }
    
}
