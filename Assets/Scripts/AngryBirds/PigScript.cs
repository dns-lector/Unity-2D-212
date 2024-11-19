using UnityEngine;

public class PigScript : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PigDestroy"))
        {
            Debug.Log(collision.gameObject.name);
        }
    }
}
/* Визначаємо зіткнення (колізії) з предметами, що "знищують" ворога
 */
