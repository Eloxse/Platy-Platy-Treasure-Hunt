using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Booty_Island : MonoBehaviour
{
    #region Variables
    [Header("Manager")]
    [SerializeField] private float timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource btnSound;

    [Header("Buttons")]
    [SerializeField] private GameObject btnBlackWater;
    [SerializeField] private GameObject btnBlindMans, btnIslandDone;

    [Header("Images")]
    [SerializeField] private GameObject imgBackground;
    [SerializeField] private GameObject imgMap;

    [Header("Pannel")]
    [SerializeField] private GameObject panDial1;
    #endregion

    #region Custom Methods
    public void NextPan()
    {
        StartCoroutine(DelayNextPan());
    }

    private IEnumerator DelayNextPan()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial1.SetActive(false);

        imgBackground.SetActive(true);
        imgMap.SetActive(true);
        btnBlackWater.SetActive(true);
        btnBlindMans.SetActive(true);
        btnIslandDone.SetActive(true);
    }

    public void LoadBlackWater()
    {
        StartCoroutine(DelayBlackWater());
    }

    private IEnumerator DelayBlackWater()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Black_Water_Cave", LoadSceneMode.Single);
    }

    public void LoadBlindMans()
    {
        StartCoroutine(DelayBlindMans());
    }

    private IEnumerator DelayBlindMans()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Blind_Mans_Lagoon", LoadSceneMode.Single);
    }
    #endregion
}
