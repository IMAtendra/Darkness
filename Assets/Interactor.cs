using UnityEngine;

internal interface IInteractable
{
    public void Interact();
}

// [ExecuteInEditMode]
public class Interactor : MonoBehaviour
{
   public Transform interactSource;
   public float interactRange;

   private void Update()
   {
     if (Input.GetKeyDown(KeyCode.E))
     {
        Ray ray = new Ray(interactSource.position, interactSource.forward);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, interactRange))
        {
            if (hitInfo.collider.gameObject.TryGetComponent(out IInteractable interactable)) 
            {
                interactable.Interact();
            }
        }
     }
   }
}