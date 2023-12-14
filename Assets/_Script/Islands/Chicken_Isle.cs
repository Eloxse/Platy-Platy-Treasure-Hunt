using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken_Isle : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource _btnSound;
    [SerializeField] private GameObject _imgBackground, _imgMap, _imgKraken, _imgSinking;
    [SerializeField] private GameObject _vid;
    [SerializeField] private GameObject _panDialogue1, _panDialogue2, _panDialogue3, _panDialogue4;
    [SerializeField] private GameObject _btnChickenIsle, _btnBlackSand;
    #endregion
	
	#region Properties
    #endregion
	
	#region Builtin Methods
    void Start()
    {
        
    }
    #endregion

    #region Custom Methods
    public void LoadVideo()
    {
        StartCoroutine(DelayVideo());
    }

    private IEnumerator DelayVideo()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _imgBackground.SetActive(false);
        _imgMap.SetActive(false);
        _panDialogue1.SetActive(false);
        _btnBlackSand.SetActive(false);
        _btnChickenIsle.SetActive(false);
        _vid.SetActive(true);
        _panDialogue2.SetActive(true);
    }

    public void Octopus()
    {
        StartCoroutine(DelayOctopus());
    }

    private IEnumerator DelayOctopus()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _vid.SetActive(false);
        _panDialogue2.SetActive(false);
        _imgBackground.SetActive(true);
        _imgKraken.SetActive(true);
        _panDialogue3.SetActive(true);
    }
    
    public void Sink()
    {
        StartCoroutine(DelaySink());
    }

    private IEnumerator DelaySink()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _vid.SetActive(false);
        _panDialogue2.SetActive(false);
        _imgBackground.SetActive(true);
        _imgSinking.SetActive(true);
        _panDialogue4.SetActive(true);
    }
    #endregion
}
