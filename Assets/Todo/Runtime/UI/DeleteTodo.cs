using UnityEngine;
using UnityEngine.EventSystems;

public class DeleteTodo : MonoBehaviour, IPointerClickHandler
{
    public TodoItem todoItem;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        Destroy(todoItem.gameObject);
    }
}
