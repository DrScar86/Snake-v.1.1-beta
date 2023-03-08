using UnityEngine;
public class Look_At : MonoBehaviour
{
    // цель, на которую должен смотреть объект
    public Transform target;
    public void Update()
    {
        if (target != null)
        {
            // Смотрим всегда на цель
            transform.LookAt(target);
        }
    }
}