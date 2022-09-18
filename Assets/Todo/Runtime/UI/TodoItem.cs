using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using Image = UnityEngine.UI.Image;
using Toggle = UnityEngine.UI.Toggle;

public class TodoItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Toggle toggle;
    public TMP_Text text;
    public Image image;

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.color = new Color(1, 1, 1, 1);
    }


    public void OnPointerExit(PointerEventData eventData)
    {
        image.color = new Color(1, 1, 1, 0.1f);
    }

    private void Start()
    {
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
    }

    private void OnToggleValueChanged(bool isOn)
    {
        text.fontStyle = isOn ? FontStyles.Strikethrough : FontStyles.Normal;
    }
}