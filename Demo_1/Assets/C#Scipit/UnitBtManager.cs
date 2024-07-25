using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public GameObject UnitPanel;
    private bool isUnitOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        UnitPanel.SetActive(false); // Start with the Unit panel closed
    }

    // Update is called once per frame
    public void ToggleUnit()
    {
        isUnitOpen = !isUnitOpen;
        UnitPanel.SetActive(isUnitOpen);
    }
}
