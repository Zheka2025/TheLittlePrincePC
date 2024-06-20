using UnityEngine;
using UnityEngine.UI;

public class InstructionsManager : MonoBehaviour
{
    public GameObject instructionsPanel;  // ������� ������ � ������������
    public Button okButton;               // ������ "OK"
    public GameObject[] instructionPages; // ����� ������� � ������������
    public Button nextButton;             // ������ ��� �������� �� �������� �������
    public Button prevButton;             // ������ ��� ���������� �� ��������� �������
    private int currentPageIndex = 0;     // ������ ������� �������

    void Start()
    {
        // �������� �� ������� ��� ����� ����������
        if (PlayerPrefs.GetInt("HasSeenInstructions", 0) == 0)
        {
            ShowInstructions();
        }
        else
        {
            instructionsPanel.SetActive(false);
        }

        // ����'���� ������ �� ������
        okButton.onClick.AddListener(CloseInstructions);
        nextButton.onClick.AddListener(ShowNextPage);
        prevButton.onClick.AddListener(ShowPreviousPage);

        // ��������� ����������� �������
        UpdatePage();
    }

    void ShowInstructions()
    {
        instructionsPanel.SetActive(true);
        Time.timeScale = 0; // ������� ���
    }

    void CloseInstructions()
    {
        instructionsPanel.SetActive(false);
        Time.timeScale = 1; // ����������� ���
        PlayerPrefs.SetInt("HasSeenInstructions", 1);
        PlayerPrefs.Save();
    }

    void ShowNextPage()
    {
        if (currentPageIndex < instructionPages.Length - 1)
        {
            currentPageIndex++;
            UpdatePage();
        }
    }

    void ShowPreviousPage()
    {
        if (currentPageIndex > 0)
        {
            currentPageIndex--;
            UpdatePage();
        }
    }

    void UpdatePage()
    {
        for (int i = 0; i < instructionPages.Length; i++)
        {
            instructionPages[i].SetActive(i == currentPageIndex);
        }

        prevButton.gameObject.SetActive(currentPageIndex > 0);
        nextButton.gameObject.SetActive(currentPageIndex < instructionPages.Length - 1);
    }
}
