using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 3f;
    public int damage = 10; // sát thương dành cho Boss

    void Start()
    {
        Destroy(gameObject, lifeTime); // tự hủy sau 3s
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Bullet hit: " + other.name + " | Tag: " + other.tag);
        // Nếu trúng Enemy (Chicken) → chỉ xóa đạn
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

        // Nếu trúng Boss → gây damage
        if (other.CompareTag("Boss"))
        {
            Destroy(gameObject);

            Boss boss = other.GetComponent<Boss>();
            if (boss != null)
            {
                boss.TakeDamage(damage); // Trừ máu Boss
            }
        }
    }
}
