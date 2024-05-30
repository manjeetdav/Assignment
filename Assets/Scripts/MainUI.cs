using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public void OnClickMainMenu()
    {
        if (GameManager.Instance != null)
        {
            GameManager.Instance.SceneTransitionCallback?.Invoke(SceneManager.MAIN_MENU);
        }
    }
}
