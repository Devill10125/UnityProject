using UnityEngine;
using TMPro;

public class EndZone : MonoBehaviour
{
    public GameObject winText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winText.SetActive(true);

            Time.timeScale = 0f;
        }
    }
}