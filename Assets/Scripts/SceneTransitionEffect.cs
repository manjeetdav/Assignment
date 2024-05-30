using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;
public class SceneTransitionEffect : MonoBehaviour
{
    [SerializeField] private Image _bgImage;
    private void Start()
    {
        if (GameManager.Instance != null) 
        {
            GameManager.Instance.SceneTransitionCallback += StartTransition;
        }
    }

    private void StartTransition(string sceneName)
    {
        _bgImage.gameObject.SetActive(true);
        _bgImage.DOFade(1f, 1f).From(0f).OnComplete(() =>
        {
            SceneManager.GotoScene(sceneName);
        });
    }
}
