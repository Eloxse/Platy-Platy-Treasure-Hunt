using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boulder_Clay : MonoBehaviour
{
    #region Variables
    [Header("Manager")]
    [SerializeField] private float timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource btnSound;

    [Header("Button")]
    [SerializeField] private GameObject btnBoulderClay; 
    [SerializeField] private GameObject btnCannonCove;

    [Header("Images")]
    [SerializeField] private GameObject imgBackground; 
    [SerializeField] private GameObject imgMap, imgSink, imgPrincess, imgTreasure;
    [SerializeField] private GameObject vid;

    [Header("Pannel")]
    [SerializeField] private GameObject panDial1;
    [SerializeField] private GameObject panDial2, panDial3, panDial4, panDial5, panDial6, panDial7;
    #endregion

    #region Custom Methods
    public void Next()
    {
        StartCoroutine(DelayNext());
    }

    private IEnumerator DelayNext()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        imgBackground.SetActive(false);
        imgMap.SetActive(false);
        panDial1.SetActive(false);
        btnBoulderClay.SetActive(false);
        btnCannonCove.SetActive(false);

        vid.SetActive(true);
        panDial2.SetActive(true);
    }

    public void DontApproach()
    {
        StartCoroutine(DelayDontApproach());
    }

    private IEnumerator DelayDontApproach()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial2.SetActive(false);

        panDial3 .SetActive(true);
    }

    public void Wait()
    {
        StartCoroutine(DelayWait());
    }

    private IEnumerator DelayWait()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial2 .SetActive(false);

        panDial4 .SetActive(true);
    }

    public void BlackSand()
    {
        StartCoroutine(DelayBlackSand());
    }

    private IEnumerator DelayBlackSand()
    {
        btnSound .Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Black_Sand_Atoll", LoadSceneMode.Single);
    }

    public void Tempest()
    {
        StartCoroutine(DelayTempest());
    }

    private IEnumerator DelayTempest()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial3.SetActive(false);

        panDial5.SetActive(true);
        imgBackground.SetActive(true);
        imgSink.SetActive(true);
    }

    public void Princess()
    {
        StartCoroutine(DelayPrincess());
    }

    private IEnumerator DelayPrincess()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial4.SetActive(false);

        panDial6 .SetActive(true);
        imgBackground.SetActive(true);
        imgPrincess.SetActive(true);
    }

    public void Treasure()
    {
        StartCoroutine(DelayTreasure());
    }

    private IEnumerator DelayTreasure()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial4.SetActive(false);

        panDial7.SetActive(true);
        imgBackground.SetActive(true);
        imgTreasure.SetActive(true);
    }
    #endregion
}