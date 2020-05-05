using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public TMP_Dropdown resolutionDropdown;
    Resolution[] resolution;
    void Start()
    {
        // make dropdown list of all resolutions
        resolution = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        int currentResolutionIndex = 0;
        List<string> options = new List<string>();

        for (int i = 0; i < resolution.Length; i++)
        {
            string option = resolution[i].width + "X" + resolution[i].height;
            options.Add(option);
            if (resolution[i].width == Screen.currentResolution.width && resolution[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
        // end
    }
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    public void SetGraphics(int index)
    {
        Debug.Log(index);
        QualitySettings.SetQualityLevel(index);
    }

    public void setFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void SetResolution(int index) 
    {
        Resolution Changeresolution = resolution[index];
        Screen.SetResolution(Changeresolution.width, Changeresolution.height, Screen.fullScreen);
    }
}
