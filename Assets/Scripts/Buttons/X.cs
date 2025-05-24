using UnityEngine;

public class X : MonoBehaviour
{
    public GameObject xMenu; // Assign your settings UI panel here

    public void OpenX()
    {
        xMenu.SetActive(true);
        Debug.Log("X menu opened.");
    }

    public void CloseX()
    {
        xMenu.SetActive(false);
        Debug.Log("X menu closed.");
    }
}
