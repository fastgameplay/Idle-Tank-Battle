using UnityEngine;

[RequireComponent(typeof(DeathManager))]
public class Health : MonoBehaviour
{
    public int MaxHealth{
        get{
            return _maxHealth;
        }
        set{
            _maxHealth = value;
            CurrentHealth = value; 
        }    
    }
    int _maxHealth;
    
    public int CurrentHealth{
        get{
            return _currentHealth;
        }
        private set{
            if(value <= 0) {
                value = 0;
                _cachedDeathManager.Destroy();
            }
            _currentHealth = value;
            //_cachedHealthBar = value;
        }
    }
    int _currentHealth;

    DeathManager _cachedDeathManager;
    int _regenirationRate;

    void Awake(){
        _cachedDeathManager = GetComponent<DeathManager>();
    }
    public void Damage(int amount){
        CurrentHealth -= amount;
        //PopTextHandler.pop(transform.location, Quaternion.identity, -amount, red);
    }
}
