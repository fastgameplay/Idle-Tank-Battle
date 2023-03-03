using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField] GameObject _enemyPrefab;

    [SerializeField] Vector2Int _quantityRange;

    [SerializeField] int _baseDamage;
    [SerializeField] int _baseHealth;
    [SerializeField] float _levelDifficultyMultiply;
    
    List<GameObject> _activeTargets;
    void GenerateWave(){
        _activeTargets = new List<GameObject>();
        int randQuantiy = Random.Range(_quantityRange.x,_quantityRange.y);
        for (int i = 0; i < randQuantiy; i++){
            _activeTargets.Add(Instantiate(_enemyPrefab,transform.position,Quaternion.identity));
        }
    }
}
