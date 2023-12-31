using UnityEngine;

public class Enemy
{
    private string enemyName;
    private float speed;

    public Health health = new Health();

    public void Move(Transform target)
    {
        Debug.Log($"Moving towards the target {target.name}");
    }

    public void Shoot(Vector3 direction, float speed)
    {
        Debug.Log($"Shooting a bullet towards {direction} with a speed of {speed}");
    }

    public void Die()
    {
        Debug.Log($"Player died");
    }

    public void Attack(float interval)
    {
        Debug.Log($"Enemy attacking with a {interval} interval");
    }
}
