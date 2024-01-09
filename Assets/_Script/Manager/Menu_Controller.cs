using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Controller : MonoBehaviour
{
    [Header("Manager")]
    [SerializeField] private float timeBeforeLoad = 0.5f;

    [Header("Sounds")]
    [SerializeField] private AudioSource btnSound;
    [SerializeField] private AudioSource ambiantSound;

    public void Start(){
        if(ambiantSound){
            ambiantSound.Play();
        }
    }

    public void LoadFilm(){
        StartCoroutine(TimeBeforeLoadFilm());
    }

    private IEnumerator TimeBeforeLoadFilm(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Cinematic", LoadSceneMode.Single);
    }

    public void ExitGame(){
        btnSound.Play();
        Application.Quit();
    }
    //Possibility to quit the game

    public void LoadMenu()
    {
        StartCoroutine(DelayMenu());
    }

    private IEnumerator DelayMenu()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
}
