using UnityEngine;

public class Team: MonoBehaviour
{
    public GameObject teamMenu; // Assign your team UI panel here

    public void OpenTeam()
    {
        teamMenu.SetActive(true);
        Debug.Log("Team menu opened.");
    }

    public void CloseTeam()
    {
        teamMenu.SetActive(false);
        Debug.Log("Team menu closed.");
    }
}
