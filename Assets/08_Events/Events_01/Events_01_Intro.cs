using UnityEngine;
using UnityEngine.UIElements;

namespace Section_Events
{
    public class Events_01_Intro : MonoBehaviour
    {
        VisualElement elem;

        private void OnEnable()
        {
            VisualElement root = GetComponent<UIDocument>().rootVisualElement;

            Slider slider = root.Q<Slider>("MySlider");
            TextField input = root.Q<TextField>("MyTextField");
            elem = root.Q("MyElem");

            /*slider.RegisterCallback<ChangeEvent<float>>(OnSliderChanged);

            input.RegisterCallback<InputEvent>(evt => Debug.Log((evt.target as VisualElement).name + " has new input"));
            input.RegisterCallback<FocusEvent>(evt => Debug.Log((evt.target as VisualElement).name + " has focus"));

            elem.RegisterCallback<PointerEnterEvent>(OnPointerEntered);*/
            elem.RegisterCallback<GeometryChangedEvent>(evt => Debug.Log((evt.target as VisualElement).name + " has geometry changed"));

        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.A))
            {
                elem.style.width = 500;
            }
        }


    }
}


