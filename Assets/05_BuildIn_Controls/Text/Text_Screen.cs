using UnityEngine;
using UnityEngine.UIElements;

public class Text_Screen : MonoBehaviour
{
    Label label;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        label = root.Q<Label>("MyLabel");
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            label.text = "I am too old for <color=#D61F1F>FORTNITE</color>";
        }
    }
}
