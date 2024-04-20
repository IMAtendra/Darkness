using UnityEngine;

public class Cube : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.LogWarning("you have interact");
    }
}