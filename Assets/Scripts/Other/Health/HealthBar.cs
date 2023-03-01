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
    [SerializeField] bool _lookAtCamera;

    Image _barImage;
    void Awake(){
        if(_lookAtCamera) transform.parent.parent.LookAt(Camera.main.transform);
        _barImage = GetComponent<Image>();    
    }
}