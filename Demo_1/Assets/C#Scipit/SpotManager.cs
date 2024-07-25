using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotManager : MonoBehaviour
{
    public GameObject SpotPanel;

    // Start is called before the first frame update
    void Start()
    {
        SpotPanel.SetActive(false); // Start with the spot panel closed
    }

    // Update is called once per frame
    public void ToggleSpotPanel()
    {
        SpotPanel.SetActive(!SpotPanel.activeSelf);
    }
}
