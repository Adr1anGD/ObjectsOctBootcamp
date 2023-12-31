using UnityEngine;

public class Player
{
    private string nickName;
    private float speed;

    public Health health = new Health(100f, 100f, 2f);

    public void Move(Vector3 direction)
    {
        Debug.Log($"Moving towards {direction}");
    }

    public void Move()
    {
        Debug.Log($"Player moving");
    }

    public void Shoot(Vector3 direction, float speed)
    {
        Debug.Log($"Shooting a bullet towards {direction} with a speed of {speed}");
    }

    public void Die()
    {
        Debug.Log($"Player died");
    }
}
