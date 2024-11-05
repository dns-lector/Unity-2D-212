using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    [SerializeField]
    private Transform rotAnchor;

    void Start()
    {
        
    }

    void Update()
    {
        float dy = Input.GetAxis("Vertical");   // "сигнал" з усіх
        // пристроїв, що відповідають за управління по вертикалі
        float currentAngle = this.transform.eulerAngles.z;
        if(currentAngle > 180)
        {
            currentAngle -= 360;
        }
        if (-45 < currentAngle + dy && currentAngle + dy < 45)
        {
            this.transform.RotateAround(rotAnchor.position, Vector3.forward, dy);
        }
    }
}
/* Скрипт управління "Стрілкою"
 * за натиском "Вгору"/"Вниз" (W/S, джойстик) стрілка змінює кут нахилу
 * 
 * Д.З. Створити нову сцену
 * Зробити її аналогічною попередній сцені, тільки розмістити іншого персонажа
 * Змінити стартову позицію
 * Для обох сцен підібрати максимальний та мінімальний кут нахилу Стрілки
 */
