using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShooting : MonoBehaviour
{    
    [SerializeField] Bullet _bulletPrefab;
    [SerializeField] TankTowerAim _tankTowerAim;
    [SerializeField] Transform _bulletSpawnPoint;
    [SerializeField] int _tankDamage;

    public void ShootAt(Transform target){
        int timesToShoot = target.GetComponent<Health>().CurrentHealth / _tankDamage;
        if(timesToShoot % _tankDamage == 0) timesToShoot--; 
        StartCoroutine(TempShoot(target, timesToShoot));
    }
    IEnumerator TempShoot(Transform target, int times){
        _tankTowerAim.Target = target;
        while (times > 0){
            
            yield return new WaitForSeconds(1.0f);
            if(target == null) break;
            Instantiate(_bulletPrefab,_bulletSpawnPoint.position,Quaternion.identity).Shoot(target).Damage = _tankDamage;
            times--;
        }
    }
}
