using UnityEngine;

public class ModalScript : MonoBehaviour
{
    [SerializeField]
    private GameObject content;
    [SerializeField]
    private TMPro.TextMeshProUGUI titleTmp;
    [SerializeField]
    private TMPro.TextMeshProUGUI messageTmp;

    void Start()
    {
        if (content.activeInHierarchy)
        {
            Time.timeScale = 0.0f;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if( content.activeInHierarchy )
            {
                HideModal();
            }
            else
            {
                ShowModal(
                    "ГРА НА ПАУЗІ",
                    "Для продовження гри натисніть кнопку \"Продовжити\" або клавішу ESC. Для зупинки гри натисніть кнопку \"Завершити\""
                );
            }

        }
    }
    public void ShowModal(string title, string message)
    {
        titleTmp.text = title;
        messageTmp.text = message;
        Time.timeScale = 0.0f;
        content.SetActive(true);
    }
    private void HideModal()
    {
        Time.timeScale = 1.0f;
        content.SetActive(false);
    }

    public void OnExitButtonClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
    public void OnResumeButtonClick()
    {
        HideModal();
    }
}
/* Д.З. На другій сцені (з попередніх ДЗ) реалізувати
 * можливість зміни персонажу (вибрати не таких, як на першій сцені),
 * роботу модального повідомлення.
 */
