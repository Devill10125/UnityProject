using UnityEngine;

public class KillZone : MonoBehaviour
{
    public Transform respawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController controller = other.GetComponent<CharacterController>();

            // Disable controller temporarily
            if (controller != null)
                controller.enabled = false;

            other.transform.position = respawnPoint.position;

            // Re-enable controller
            if (controller != null)
                controller.enabled = true;
        }
    }
}