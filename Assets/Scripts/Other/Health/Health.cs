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
            _cachedHealthBar.Percent = value / (float)_maxHealth;;
        }
    }
    int _currentHealth;

    DeathManager _cachedDeathManager;
    [SerializeField] HealthBar _cachedHealthBar;
    int _regenirationRate;

    void Awake(){
        _cachedDeathManager = GetComponent<DeathManager>();
        MaxHealth = 1000;
    }
    public void Damage(int amount){
        Debug.Log($"DAmage Income {amount} with current health {CurrentHealth}");
        CurrentHealth -= amount;
        Debug.Log($"HealthAfter Damage {CurrentHealth}");
        //PopTextHandler.pop(transform.location, Quaternion.identity, -amount, red);
    }
}
