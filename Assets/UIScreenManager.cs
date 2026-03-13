using UnityEngine;

public class UIScreenManager : MonoBehaviour
{
    public GameObject homeScreen;
    public GameObject visualCheck;

    public void OpenVisualCheck()
    {
        homeScreen.SetActive(false);
        visualCheck.SetActive(true);
    }
}