using UnityEngine;

public class NonDestroyable : MonoBehaviour, IDeathHandler{
    public void Death(){
        gameObject.SetActive(false);
    } 
}
