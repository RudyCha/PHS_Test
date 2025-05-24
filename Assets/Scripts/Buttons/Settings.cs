using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public GameObject settingsMenu;
    public Slider volumeSlider;
    public Text volumeValueText;

    private void Start()
    {
        float savedVolume = PlayerPrefs.GetFloat("GameVolume", 1f);
        AudioListener.volume = savedVolume;

        if (volumeSlider != null)
        {
            volumeSlider.value = savedVolume;
            volumeSlider.onValueChanged.AddListener(SetVolume);
        }

        UpdateVolumeText(savedVolume);
    }

    public void OpenSettings()
    {
        settingsMenu.SetActive(true);  // Activate the settings menu
        Debug.Log("Settings menu opened.");
    }

    public void CloseSettings()
    {
        settingsMenu.SetActive(false); // Deactivate the settings menu
        Debug.Log("Settings menu closed.");
    }

    public void SetVolume(float value)
    {
        AudioListener.volume = value;
        PlayerPrefs.SetFloat("GameVolume", value);
        UpdateVolumeText(value);  // Update the volume text display
    }

    private void UpdateVolumeText(float value)
    {
        if (volumeValueText != null)
        {
            int percent = Mathf.RoundToInt(value * 100);
            volumeValueText.text = $"Volume: {percent}%"; //Updating Volume%
        }
    }
}
