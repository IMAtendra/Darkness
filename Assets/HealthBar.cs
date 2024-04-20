using UnityEngine.UIElements;

public class HealthBar : VisualElement
{
    public VisualElement backgroundBar;
    public VisualElement foregroundBar;
    public float lowValue { get; set; }
    public float highValue { get; set; }
    public float value { get; set; }

    public HealthBar()
    {
        backgroundBar = new VisualElement();
        this.Add(backgroundBar);
        
        foregroundBar = new VisualElement();
        this.Add(foregroundBar);

        Update();
    }

    // Update is called once per frame
    void Update()
    {
        foregroundBar.style.width = new StyleLength(new Length(value, LengthUnit.Percent));
    }
}


// public class HealthBar : VisualElement
// {
//     public new UxmlFactory : UxmlFactory<HealthBar, UxmlTraits> {}
//     public new UxmlTraits : BindableElement.UxmlTraits
//     {
//         UxmlAttributeDescription m_LowValue = new UxmlAttributeDescription {
//             name = "low-value", defaultValue = 0
//         };
//         UxmlAttributeDescription m_HighValue = new UxmlAttributeDescription {
//             name = "high-value", defaultValue = 100
//         };
//         UxmlAttributeDescription m_Value = new UxmlAttributeDescription {
//             name = "value", defaultValue = 0
//         };
//         public override void init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
//         {
//             base.init(ve, bag, cc);
//             var bar  = ve as HealthBar;
//             bar.lowValue = m_LowValue.GetValueFromBag(bag, cc);
//             bar.highValue = m_HighValue.GetValueFromBag(bag, cc);
//             bar.value = m_Value.GetValueFromBag(bag, cc);
//         }
//     }
// }

