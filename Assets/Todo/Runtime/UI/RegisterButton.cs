
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class RegisterButton : MonoBehaviour, IPointerClickHandler
{
    public TMP_InputField inputField;

    public TodoItem item;

    public TodoListView todoListView;
    
    
    public void OnPointerClick(PointerEventData eventData)
    {
        var newTodo = inputField.text;
        // Implement Register
        item.text.text = newTodo;
        
        var todo = Instantiate(item, todoListView.transform);
        var todoTransform = todo.transform;
        todoTransform.parent = todoListView.transform;
        todoTransform.localScale = new Vector3(1, 1, 1);
        
        
        inputField.text = "";
    }
}
