using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Marchand : MonoBehaviour
{
    #region Variables
    [SerializeField] private float timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource btnSound;

    [Header("Buttons")]
    [SerializeField] private GameObject btnBoat1;
    [SerializeField] private GameObject btnBoat2, btnBoat3;
    [SerializeField] private GameObject btnIsland1, btnIsland2, btnIsland3;

    [Header("Images")]
    [SerializeField] private GameObject imgSeller;
    [SerializeField] private GameObject imgTheWise, imgMap;

    [Header("Pannel")]
    [SerializeField] private GameObject panDial1;
    [SerializeField] private GameObject panDial2, panDial3;
    #endregion

    #region Custom Methods
    public void ChoiceBoat()
    {
        StartCoroutine(DelayChoiceBoat());
    }

    private IEnumerator DelayChoiceBoat()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        imgSeller.SetActive(false);
        panDial1.SetActive(false);

        btnBoat1.SetActive(true);
        btnBoat2.SetActive(true);
        btnBoat3.SetActive(true);
        panDial2.SetActive(true);
    }
    //Load UI to choose the boat

    public void BoatButton()
    {
        StartCoroutine(TimeBeforeBoatButton());
    }

    private IEnumerator TimeBeforeBoatButton()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        btnBoat1.SetActive(false);
        btnBoat2.SetActive(false);
        btnBoat3.SetActive(false);
        panDial2.SetActive(false);

        imgTheWise.SetActive(true);
        panDial3.SetActive(true);
    }
    //Possibility to choose the boat

    public void LoadMap()
    {
        StartCoroutine(DelayLoadMap());
    }

    private IEnumerator DelayLoadMap()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        imgTheWise.SetActive(false);
        panDial3.SetActive(false);
        imgMap.SetActive(true);
        btnIsland1.SetActive(true);
        btnIsland2.SetActive(true);
        btnIsland3.SetActive(true);
    }
    //Load the Map UI with th choices 

    public void LoadBlackSandAtoll()
    {
        StartCoroutine(DelayBlackSandAtoll());
    }

    private IEnumerator DelayBlackSandAtoll()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Black_Sand_Atoll", LoadSceneMode.Single);
    }

    public void LoadBootyIsland()
    {
        StartCoroutine(DelayBootyIsland());
    }

    private IEnumerator DelayBootyIsland()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Booty_Island", LoadSceneMode.Single);
    }

    public void LoadCannonCove()
    {
        StartCoroutine(DelayCannonCove());
    }

    private IEnumerator DelayCannonCove()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Cannon_Cove", LoadSceneMode.Single);
    }
    //Load scenes
    #endregion
}