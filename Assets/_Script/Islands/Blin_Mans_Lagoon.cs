using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blin_Mans_Lagoon : MonoBehaviour
{
    #region Variables
    [Header("Manager")]
    [SerializeField] private float timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource btnSound;

    [Header("Button")]
    [SerializeField] private GameObject btnCannon;
    [SerializeField] private GameObject btnBoulder, btnBlindMans, btnBooty;

    [Header("Images")]
    [SerializeField] private GameObject imgBackground;
    [SerializeField] private GameObject imgMap, imgPrincess, imgTreasure, imgTooLate;

    [Header("Pannel")]
    [SerializeField] private GameObject panDial2;
    [SerializeField] private GameObject panDial3, panDial4, panDial5, panDial6, panDial7;
    #endregion

    #region Custom Methods
    public void GoingBack(){
        StartCoroutine(DelayGoingBack());
    }

    private IEnumerator DelayGoingBack(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial2.SetActive(false);

        panDial3.SetActive(true);
        imgBackground.SetActive(true);
        imgMap.SetActive(true);
        btnBoulder.SetActive(true);
        btnCannon.SetActive(true);
        btnBlindMans.SetActive(true);
        btnBooty.SetActive(true);
    }

    public void LoadCannonCove(){
        StartCoroutine(DelayCannonCove());
    }

    private IEnumerator DelayCannonCove(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Cannon_Cove", LoadSceneMode.Single);
    }

    public void LoadBoulderClay(){
        StartCoroutine(DelayBoulderClay());
    }

    private IEnumerator DelayBoulderClay(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial3.SetActive(false);
        btnBlindMans.SetActive(false);
        btnBooty.SetActive(false);
        btnBoulder.SetActive(false);
        btnCannon.SetActive(false);
        imgMap.SetActive(false);

        panDial4.SetActive(true);
        imgBackground.SetActive(true);
        imgPrincess.SetActive(true);
    }

    public void Landing(){
        StartCoroutine(DelayLanding());
    }

    private IEnumerator DelayLanding(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial2.SetActive(false);

        panDial5.SetActive(true);
    }

    public void Forest(){
        StartCoroutine(DelayForest());
    }

    private IEnumerator DelayForest(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial5.SetActive(false);

        panDial6.SetActive(true);
        imgBackground.SetActive(true);
        imgTreasure.SetActive(true);
    }

    public void Beach(){
        StartCoroutine(DelayBeach());
    }

    private IEnumerator DelayBeach(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial5.SetActive(false);

        panDial7.SetActive(true);
        imgBackground.SetActive(true);
        imgTooLate.SetActive(true);
    }
    #endregion
}