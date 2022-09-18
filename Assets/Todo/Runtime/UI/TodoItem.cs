using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class TodoItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public TMP_Text text;

    public Image image;
    
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        image.color = new Color(100, 100, 100, 100f);
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        image.color = new Color(255,255,255, 0.1f);
    }
}
