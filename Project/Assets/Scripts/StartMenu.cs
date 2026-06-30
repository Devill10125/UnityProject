using Cinemachine;
using StarterAssets;
using TMPro.Examples;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject menuUI;

    public MonoBehaviour cameraLookScript;

    void Start()
    {
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        cameraLookScript.enabled = false;
    }

    public void StartGame()
    {
        menuUI.SetActive(false);

        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        cameraLookScript.enabled = true;
    }
}