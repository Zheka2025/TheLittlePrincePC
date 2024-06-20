using UnityEngine;

public class ShowCanvasOnCollision : MonoBehaviour
{
    public GameObject canvas;

    private void Start()
    {
        // �������������, �� ������ �������� ���������
        canvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ��������, �� �������� �������� � �������
        if (collision.CompareTag("Player"))
        {
            // ³���������� �������
            canvas.SetActive(true);
        }
    }
}
