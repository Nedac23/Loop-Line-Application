using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Dragableitem : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler
{
    public Image image;
    public bool winner;
    [HideInInspector] public Transform parentAfterDrag;
    public void OnBeginDrag(PointerEventData eventData)
    {
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
       // throw new System.NotImplementedException();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
     //   throw new System.NotImplementedException();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //throw new System.NotImplementedException();
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }


}
