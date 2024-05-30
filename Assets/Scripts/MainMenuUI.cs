using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public void OnClickGameScene()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.SceneTransitionCallback?.Invoke(SceneManager.GAME_SCENE);
        }
    }
}
