using UnityEngine;

public class Store : MonoBehaviour
{
    public GameObject storeMenu; // Assign your settings UI panel here

    public void OpenStore()
    {
        storeMenu.SetActive(true);
        Debug.Log("Store menu opened.");
    }

    public void CloseStore()
    {
        storeMenu.SetActive(false);
        Debug.Log("Store menu closed.");
    }
}
