using UnityEngine;

public class BirdScript : MonoBehaviour
{
    [SerializeField]
    private Transform arrow;
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(1000 * arrow.right);
        }
    }
}
/* Управління персонажем (птахом)
 * За натисненням кнопки "Пробіл" одноразово прикладаємо силу
 * у напрямі Стрілки
 */
