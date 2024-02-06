using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Black_Water : MonoBehaviour
{
    #region Variables
    [Header("Manager")]
    [SerializeField] private float timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource btnSound;

    [Header("Images")]
    [SerializeField] private GameObject imgBackground;
    [SerializeField] private GameObject imgMegalodon, imgKiller;

    [Header("Pannel")]
    [SerializeField] private GameObject panDial2;
    [SerializeField] private GameObject panDial3, panDial4, panDial5, panDial6;
    #endregion

    #region Custom Methods
    public void Refuling(){
        StartCoroutine(DelayRefuling());
    }

    private IEnumerator DelayRefuling(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial2.SetActive(false);

        panDial3.SetActive(true);
    }
    
    public void Arise(){
        StartCoroutine(DelayArise());
    }

    private IEnumerator DelayArise(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial2.SetActive(false);

        panDial4.SetActive(true);
    }
    
    public void Megalodon(){
        StartCoroutine(DelayMegalodon());
    }

    private IEnumerator DelayMegalodon(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial3.SetActive(false);

        panDial5.SetActive(true);
        imgBackground.SetActive(true);
        imgMegalodon.SetActive(true);
    }
    
    public void Count(){
        StartCoroutine(DelayCount());
    }

    private IEnumerator DelayCount(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Blind_Mans_Lagoon", LoadSceneMode.Single);
    }
    
    public void Killer(){
        StartCoroutine(DelayKiller());
    }

    private IEnumerator DelayKiller(){
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial4.SetActive(false);

        panDial6.SetActive(true);
        imgBackground.SetActive(true);
        imgKiller.SetActive(true);
    }
    #endregion
}
