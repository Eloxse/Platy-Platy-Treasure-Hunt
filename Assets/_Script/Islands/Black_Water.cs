using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Black_Water : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource _btnSound;
    [SerializeField] private GameObject _panDialogue2, _panDialogue3, _panDialogue4, _panDialogue5, _panDialogue6;
    [SerializeField] private GameObject _imgBackground, _imgMegalodon, _imgKiller;
    #endregion

    #region Custom Methods
    public void Refuling(){
        StartCoroutine(DelayRefuling());
    }

    private IEnumerator DelayRefuling(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue2.SetActive(false);
        _panDialogue3.SetActive(true);
    }
    
    public void Arise(){
        StartCoroutine(DelayArise());
    }

    private IEnumerator DelayArise(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue2.SetActive(false);
        _panDialogue4.SetActive(true);
    }
    
    public void Megalodon(){
        StartCoroutine(DelayMegalodon());
    }

    private IEnumerator DelayMegalodon(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue3.SetActive(false);
        _panDialogue5.SetActive(true);
        _imgBackground.SetActive(true);
        _imgMegalodon.SetActive(true);
    }
    
    public void Count(){
        StartCoroutine(DelayCount());
    }

    private IEnumerator DelayCount(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        SceneManager.LoadScene("Blind_Mans_Lagoon", LoadSceneMode.Single);
    }
    
    public void Killer(){
        StartCoroutine(DelayKiller());
    }

    private IEnumerator DelayKiller(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue4.SetActive(false);
        _panDialogue6.SetActive(true);
        _imgBackground.SetActive(true);
        _imgKiller.SetActive(true);
    }
    #endregion
}
