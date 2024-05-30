using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SceneManager
{
    public const string GAME_SCENE = "GameScene";
    public const string MAIN_MENU = "MainMenu";

    public static void GotoScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
