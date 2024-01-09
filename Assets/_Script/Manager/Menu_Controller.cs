using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour
{
    [Header("Manager")]
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [Header("Sounds")]
    [SerializeField] private AudioSource _btnSound;
    [SerializeField] private AudioSource _ambiantSound;

    public void Start(){
        if(_ambiantSound){
            _ambiantSound.Play();
        }
    }

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
    //Possibility to quit the game

    public void LoadMenu()
    {
        StartCoroutine(DelayMenu());
    }

    private IEnumerator DelayMenu()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
