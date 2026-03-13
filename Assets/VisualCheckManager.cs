using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class VisualCheckManager : MonoBehaviour
{
    public TextMeshProUGUI questionText;

    public TextMeshProUGUI option1;
    public TextMeshProUGUI option2;
    public TextMeshProUGUI option3;

    // Parent object that contains the 3 option buttons
    public GameObject OptionButtons;

    // Parent object that contains the final buttons
    public GameObject EndButtons;

    // Heart images in hierarchy
    public Image[] hearts;

    // Sprites from Figma
    public Sprite love;      // filled heart
    public Sprite favorite;  // empty heart

    private int questionIndex = 0;

    string[] questions =
    {
        "Are both sides evenly shaped without swelling?",
        "Check for dimpling, puckering, or bulging.",
        "Has either nipple changed position?",
        "Do you notice a newly inverted nipple?",
        "Look for redness, rash, swelling, or discharge."
    };

    string[,] options =
    {
        {"Yes","No","Not Sure"},
        {"No Changes","Dimpling / Puckering","Not Sure"},
        {"No Changes","Yes","Not Sure"},
        {"No","Yes","Not Sure"},
        {"None","Redness / Rash / Discharge","Not Sure"}
    };

    void Start()
    {
        EndButtons.SetActive(false);
        OptionButtons.SetActive(true);

        ShowQuestion();
    }

    public void NextQuestion()
    {
        questionIndex++;

        if (questionIndex < questions.Length)
        {
            ShowQuestion();
        }
        else
        {
            ShowEndScreen();
        }
    }

    void ShowQuestion()
    {
        questionText.text = questions[questionIndex];

        option1.text = options[questionIndex, 0];
        option2.text = options[questionIndex, 1];
        option3.text = options[questionIndex, 2];

        UpdateHearts();
    }

    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i == questionIndex)
            {
                hearts[i].sprite = love;      // filled heart
            }
            else
            {
                hearts[i].sprite = favorite;  // empty heart
            }
        }
    }

    void ShowEndScreen()
    {
        questionText.text = "Visual check completed.";

        OptionButtons.SetActive(false);
        EndButtons.SetActive(true);
    }
}