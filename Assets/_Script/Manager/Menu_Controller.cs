using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour
{
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource _btnSound;

    public void LoadFilm(){
        StartCoroutine(TimeBeforeLoadFilm());
    }

    private IEnumerator TimeBeforeLoadFilm(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        SceneManager.LoadScene("Cinematic", LoadSceneMode.Single);
    }

    public void ExitGame(){
        _btnSound.Play();
        Application.Quit();
    }
}
