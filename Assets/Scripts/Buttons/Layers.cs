using UnityEngine;

public class Layers : MonoBehaviour
{
    public GameObject layersMenu; // Assign your settings UI panel here

    public void OpenLayers()
    {
        layersMenu.SetActive(true);
        Debug.Log("Layers menu opened.");
    }

    public void CloseLayers()
    {
        layersMenu.SetActive(false);
        Debug.Log("Layers menu closed.");
    }
}
