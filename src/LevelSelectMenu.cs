using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelectMenu : MonoBehaviour
{
    public Button level1Button;
    public Button level2Button;
    public Button level3Button;

    void Start()
    {
        // ����������� ���� �������� ����
        int levelReached = PlayerPrefs.GetInt("LevelReached", 1);

        // ������������ �������������� ������ � ��������� �� �������� ����
        level1Button.interactable = levelReached >= 1;
        level2Button.interactable = levelReached >= 2;
        level3Button.interactable = levelReached >= 3;

        // ������ ��������� ��������� �� ������
        level1Button.onClick.AddListener(() => LoadLevel(1));
        level2Button.onClick.AddListener(() => LoadLevel(2));
        level3Button.onClick.AddListener(() => LoadLevel(3));
    }

    void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene("Lvl" + levelIndex);
    }
}
