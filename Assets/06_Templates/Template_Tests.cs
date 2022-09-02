using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;

namespace Templates_04
{
    public class Template_Tests : MonoBehaviour
    {
        VisualElement cardContainer;

        private void OnEnable()
        {
            VisualElement root = GetComponent<UIDocument>().rootVisualElement;

            cardContainer = root.Q("CardContainer");

            VisualTreeAsset template = Resources.Load<VisualTreeAsset>("CardTemplate");

            VisualElement cardElem1 = template.Instantiate();
            cardContainer.Add(cardElem1);

            VisualElement cardElem2 = template.Instantiate();
            cardContainer.Add(cardElem2);

            // loading images
            Sprite img_person1 = Resources.Load<Sprite>("img/img_lara");
            VisualElement avatarElem1 = cardElem1.Q("Avatar");
            avatarElem1.style.backgroundImage = new StyleBackground(img_person1);

            // loading stylesheets
            StyleSheet borderStyle = Resources.Load<StyleSheet>("stylesheets/Stylesheet_Border");
            root.styleSheets.Add(borderStyle);

            VisualElement actualCard = cardElem1.Children().First();
            actualCard.AddToClassList("grey_border");

        }
    }
}


