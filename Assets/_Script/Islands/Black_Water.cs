using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black_Water : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource _btnSound;
    [SerializeField] private GameObject _panDialogue2, _panDialogue3, _panDialogue4;
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
    #endregion
}
