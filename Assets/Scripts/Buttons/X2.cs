using UnityEngine;

public class X2 : MonoBehaviour
{
    public GameObject x2Menu; // Assign your settings UI panel here

    public void OpenX2()
    {
        x2Menu.SetActive(true);
        Debug.Log("X2 menu opened.");
    }

    public void CloseX2()
    {
        x2Menu.SetActive(false);
        Debug.Log("X2 menu closed.");
    }
}
