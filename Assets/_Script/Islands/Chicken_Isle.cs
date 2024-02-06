using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken_Isle : MonoBehaviour
{
    #region Variables
    [Header("Manager")]
    [SerializeField] private float timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource btnSound;

    [Header("Manager")]
    [SerializeField] private GameObject btnChickenIsle; 
    [SerializeField] private GameObject btnBlackSand;

    [Header("Manager")]
    [SerializeField] private GameObject imgBackground;
    [SerializeField] private GameObject imgMap, imgKraken, imgSinking;
    [SerializeField] private GameObject vid;

    [Header("Manager")]
    [SerializeField] private GameObject panDial1;
    [SerializeField] private GameObject panDial2, panDial3, panDial4;
    #endregion

    #region Custom Methods
    public void LoadVideo()
    {
        StartCoroutine(DelayVideo());
    }

    private IEnumerator DelayVideo()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        imgBackground.SetActive(false);
        imgMap.SetActive(false);
        panDial1.SetActive(false);
        btnBlackSand.SetActive(false);
        btnChickenIsle.SetActive(false);

        vid.SetActive(true);
        panDial2.SetActive(true);
    }

    public void Octopus()
    {
        StartCoroutine(DelayOctopus());
    }

    private IEnumerator DelayOctopus()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        vid.SetActive(false);
        panDial2.SetActive(false);

        imgBackground.SetActive(true);
        imgKraken.SetActive(true);
        panDial3.SetActive(true);
    }
    
    public void Sink()
    {
        StartCoroutine(DelaySink());
    }

    private IEnumerator DelaySink()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        vid.SetActive(false);
        panDial2.SetActive(false);

        imgBackground.SetActive(true);
        imgSinking.SetActive(true);
        panDial4.SetActive(true);
    }
    #endregion
}
