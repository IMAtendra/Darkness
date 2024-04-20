using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Raycast : MonoBehaviour
{
    public Image img;

    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name == "Player")
                {
                    if (img.enabled == true)
                    {
                        img.gameObject.SetActive(false);
                        Debug.Log("print");
                    }
                    else if (img.enabled == false)
                    {
                        img.gameObject.SetActive(true);
                        Debug.Log("print not");

                    }
                }
            }
        }
    }

    // public void OnPointerClick(PointerEventData eventData)
    // {
    //     Debug.Log("Click DETECTED ON RIFFLE IMAGE");
       
    // }
}
