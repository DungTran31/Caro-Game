using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text winnerName;
    public Button restartButton;

    private void Awake()
    {
        restartButton.onClick.AddListener(OnClick);
    }

    public void SetName(string s) 
    { 
        winnerName.text = s;
    }
    public void OnClick()
    {
        SceneManager.LoadScene("Game");
    }
}
