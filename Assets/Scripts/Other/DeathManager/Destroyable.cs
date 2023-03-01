using UnityEngine;

public class Destroyable : MonoBehaviour,IDeathHandler{
    public void Death(){
        Destroy(gameObject);
    } 
}
