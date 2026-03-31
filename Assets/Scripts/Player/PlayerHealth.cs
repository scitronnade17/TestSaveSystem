using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health;
    public int GetHealth() => health;
    public void SetHealth(int newHealth) => health = newHealth;
}
