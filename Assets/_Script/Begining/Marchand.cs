using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Marchand : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource _btnSound;
    [SerializeField] private GameObject _boatButton1;
    [SerializeField] private GameObject _boatButton2;
    [SerializeField] private GameObject _boatButton3;
    [SerializeField] private GameObject _imgMarchand;
    [SerializeField] private GameObject _imgLeSage;
    [SerializeField] private GameObject _imgMap;
    [SerializeField] private GameObject _panDialogue1;
    [SerializeField] private GameObject _panDialogue2;
    [SerializeField] private GameObject _panDialogue3;
    #endregion

    #region Properties
    #endregion

    #region Builtin Methods
    #endregion

    #region Custom Methods
    public void ChoiceBoat()
    {
        StartCoroutine(DelayChoiceBoat());
    }

    private IEnumerator DelayChoiceBoat()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _imgMarchand.SetActive(false);
        _panDialogue1.SetActive(false);
        _boatButton1.SetActive(true);
        _boatButton2.SetActive(true);
        _boatButton3.SetActive(true);
        _panDialogue2.SetActive(true);
    }
    public void BoatButton()
    {
        StartCoroutine(TimeBeforeBoatButton());
    }

    private IEnumerator TimeBeforeBoatButton()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _boatButton1.SetActive(false);
        _boatButton2.SetActive(false);
        _boatButton3.SetActive(false);
        _panDialogue2.SetActive(false);
        _imgLeSage.SetActive(true);
        _panDialogue3.SetActive(true);
    }

    public void LoadMap()
    {
        StartCoroutine(DelayLoadMap());
    }

    private IEnumerator DelayLoadMap()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _imgLeSage.SetActive(false);
        _panDialogue3.SetActive(false);
        _imgMap.SetActive(true);
    }

    public void LoadBlackSandAtolIsland()
    {
        StartCoroutine(DelayBlackSandAtol());
    }

    private IEnumerator DelayBlackSandAtol()
    {
        yield return new WaitForSeconds(_timeBeforeLoad);
    }
    #endregion
}