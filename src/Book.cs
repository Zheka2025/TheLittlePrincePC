using UnityEngine;

public class Book : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // ³�������� ��������� �����
            int levelReached = PlayerPrefs.GetInt("LevelReached", 1);
            PlayerPrefs.SetInt("LevelReached", levelReached + 1);
            PlayerPrefs.Save();

            // ����������� �� ���� ����
            UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSelect");
        }
    }
}
