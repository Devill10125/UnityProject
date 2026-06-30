using StarterAssets;
using UnityEngine;
using static StarterAssets.ThirdPersonController;

public class Ladder : MonoBehaviour
{
    public Transform playerController;
    bool inside = false;
    public float climbSpeed = 3f;
    public ThirdPersonController player;
    public AudioSource sound;
    public StarterAssetsInputs input;

    void Start()
    {
        player = GetComponent<ThirdPersonController>(); 
        inside = false;
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Ladder")
        {
            Debug.Log("TouchingLadderTrue");
            player.enabled = false;
            inside = !inside;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Ladder")
        {
            Debug.Log("TouchingLadderFalse");
            player.enabled = true;
            inside = !inside;
        }
    }

    void Update()
    {
        if(inside == true && input.move.y > 0)
        {
            player.transform.position += Vector3.up / climbSpeed * Time.deltaTime;
        }
        if (inside == true && input.move.y < 0)
        {
            player.transform.position += Vector3.down / climbSpeed * Time.deltaTime;
        }
        if (inside == true && input.move.y > 0 || inside == true && input.move.y < 0) 
        {
            sound.enabled = true;
            sound.loop = true;
        }
        else
        {
            sound.enabled = false;
            sound.loop = false;
        }
    }
}
