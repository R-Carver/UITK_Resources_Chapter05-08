using UnityEngine;
using UnityEngine.UIElements;

public class Slider_Screen : MonoBehaviour
{
    VisualElement box;
    Slider slider;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        box = root.Q("Box");
        slider = root.Q<Slider>("MySlider");

        slider.RegisterCallback<ChangeEvent<float>>(OnSliderChanged);
    }

    void OnSliderChanged(ChangeEvent<float> evt)
    {
        box.style.width = evt.newValue;
    }
}
