using System.Collections;
using UnityEngine;

[RequireComponent(typeof(DeathManager))]
public class DeathAfterSeconds : MonoBehaviour{
    [SerializeField] float _time = 0;
    DeathManager _cachedDeathManager;

    void Awake(){
        _cachedDeathManager = GetComponent<DeathManager>();
        StartCoroutine(IEDeathAfter(_time));
    }
    IEnumerator IEDeathAfter(float time)
    {
        yield return new WaitForSeconds(time);
        _cachedDeathManager.Destroy();
    }
}