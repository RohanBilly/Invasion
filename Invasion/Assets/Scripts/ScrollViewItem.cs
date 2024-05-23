using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScrollViewItem : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Image childImage;

    public void ChangeImage(Sprite image)
    {
        childImage.sprite = image;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("CLICKED ITEM: "+ gameObject.name);
    }
}
