using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Test01UISlider : MonoBehaviour
{
    [SerializeField]
    private Slider slider;
    [SerializeField]
    private TMP_Text txtMin;
    [SerializeField]
    private TMP_Text txtMax;

    public System.Action<float> onValueChanged;
    public void Init(float min, float max)
    {
        this.slider.minValue = min;
        this.slider.maxValue = max;
        this.txtMin.text = this.slider.minValue.ToString();
        this.txtMax.text = this.slider.maxValue.ToString();

        this.slider.onValueChanged.AddListener((val) => {
            this.onValueChanged(val);
        });
    }
}
