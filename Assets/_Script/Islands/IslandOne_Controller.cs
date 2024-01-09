using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IslandOne_Controller : MonoBehaviour
{
    #region Variables
    [Header("Manager")]
    [SerializeField] private float timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource btnSound;

    [Header("Buttons")]
    [SerializeField] private GameObject btnChoice1;
    [SerializeField] private GameObject btnChoice2;

    [Header("Images")]
    [SerializeField] private GameObject imgClement;
    [SerializeField] private GameObject imgBackground, imgLost;

    [Header("Pannel")]
    [SerializeField] private GameObject panDial1;
    [SerializeField] private GameObject panDial2, panDial3, panDial4;
    #endregion

    #region Custom Methods
    public void NextPannel()
    {
        StartCoroutine(DelayNextPannel());
    }

    private IEnumerator DelayNextPannel()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial1.SetActive(false);

        panDial2.SetActive(true);
    }

    public void ChoiceOne()
    {
        StartCoroutine(DelayChoiceOne());
    }

    private IEnumerator DelayChoiceOne()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial2.SetActive(false);

        imgBackground.SetActive(true);
        imgClement.SetActive(true);
        panDial3.SetActive(true);
    }

    public void ChoiceTwo()
    {
        StartCoroutine(DelayChoiceTwo());
    }

    private IEnumerator DelayChoiceTwo()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Chicken_Isle", LoadSceneMode.Single);
    }

    public void Lost(){
        StartCoroutine(DelayLost());
    }

    private IEnumerator DelayLost(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial3.SetActive(false);
        imgClement.SetActive(false);

        panDial4.SetActive(true);
        imgLost.SetActive(true);
    }
    #endregion
}
