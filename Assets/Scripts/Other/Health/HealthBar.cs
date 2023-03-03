using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class HealthBar : MonoBehaviour
{
    public float Percent{
        set{
            _barImage.fillAmount = Mathf.Clamp(value,0.0f,1.0f);
        }
    }
    Image _barImage;
    void Awake(){
        _barImage = GetComponent<Image>();  
    }
}