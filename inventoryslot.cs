using UnityEngine;
using UnityEngine.EventSystems;

public class inventoryslot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if(transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            Dragableitem dragableitem = dropped.GetComponent<Dragableitem>();
            dragableitem.parentAfterDrag = transform;
        }
        //   throw new System.NotImplementedException();
        
    }

 
}
