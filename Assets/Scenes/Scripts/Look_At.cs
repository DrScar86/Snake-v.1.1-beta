using UnityEngine;
public class Look_At : MonoBehaviour
{
    // ����, �� ������� ������ �������� ������
    public Transform target;
    public void Update()
    {
        if (target != null)
        {
            // ������� ������ �� ����
            transform.LookAt(target);
        }
    }
}