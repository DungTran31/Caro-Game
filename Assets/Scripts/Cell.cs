using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public GameObject gameOverScreen;
    private Transform canvas;
    public int row;
    public int col;
    private Board board;
    public Sprite xSprite;
    public Sprite oSprite;

    private Image image;
    private Button button;

    private void Awake()
    {
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void Start()
    {
        board = FindObjectOfType<Board>();
        canvas = FindObjectOfType<Canvas>().transform;
    }

    public void ChangeImage(string s)
    {
        if(s == "x")
        {
            image.sprite = xSprite;
        }
        else
        {
            image.sprite = oSprite;
        }
    }

    public void OnClick()
    {
        ChangeImage(board.currentTurn);
        if (board.Check(this.row, this.col))
        {
            GameObject screen = Instantiate(gameOverScreen, canvas);
            screen.GetComponent<GameOverScreen>().SetName(board.currentTurn);
        }  
        if(board.currentTurn == "x")
        {
            board.currentTurn = "o";
        }
        else
        {
            board.currentTurn = "x";
        }
    }
}
