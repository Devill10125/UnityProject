using UnityEngine;
using UnityEngine.InputSystem;

public class Doors : MonoBehaviour
{
    public Animator door;
    public GameObject openText;
    public AudioSource doorOpenSound;
    public AudioSource doorCloseSound;
    public bool inReach;
    public bool isOpen;
    public InputAction interactAction;

    void Start()
    {
        inReach = false;
        isOpen = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Reach")
        {
            inReach = true;
            openText.SetActive(true);
            interactAction.Enable();
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Reach")
        {
            inReach = false;
            openText.SetActive(false);
            interactAction.Disable();
        }
    }

    void Update()
    {
        if(inReach == true && interactAction.WasPerformedThisFrame() && isOpen == false)
        {
            DoorOpens();
        }
        else if(inReach == true && interactAction.WasPerformedThisFrame() && isOpen == true)
        {
            DoorCloses();
        }
    }
    void DoorOpens()
    {
        Debug.Log("It Opens");
        door.SetBool("Open", true);
        door.SetBool("Closed", false);
        doorOpenSound.Play();
        isOpen = !isOpen;
    }
    void DoorCloses()
    {
        Debug.Log("It Closes");
        door.SetBool("Open", false);
        door.SetBool("Closed", true);
        doorCloseSound.Play();
        isOpen = !isOpen;
    }
}
