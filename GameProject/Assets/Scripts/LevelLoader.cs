using UnityEngine.UI;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public Button[] levelButton;

    private void Start()
    {
        foreach (Button b in levelButton)
            b.interactable = false;
        int reachedLevel = PlayerPrefs.GetInt("ReachedLevel", 1);

        for (int i = 0; i < reachedLevel; i++)
            levelButton[i].interactable = true;
    }

}
