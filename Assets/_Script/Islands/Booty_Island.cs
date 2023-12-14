using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Booty_Island : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource _btnSound;
    [SerializeField] private GameObject _imgBackground, _imgMap;
    [SerializeField] private GameObject _panDialogue1;
    [SerializeField] private GameObject _btnBlackWater, _btnBlindMans, _btnIslandDone;
    #endregion
	
	#region Properties
    #endregion
	
	#region Builtin Methods
    void Start()
    {
        
    }
    #endregion

    #region Custom Methods
    public void NextPan()
    {
        StartCoroutine(DelayNextPan());
    }

    private IEnumerator DelayNextPan()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue1.SetActive(false);
        _imgBackground.SetActive(true);
        _imgMap.SetActive(true);
        _btnBlackWater.SetActive(true);
        _btnBlindMans.SetActive(true);
        _btnIslandDone.SetActive(true);
    }

    public void LoadBlackWater()
    {
        StartCoroutine(DelayBlackWater());
    }

    private IEnumerator DelayBlackWater()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        SceneManager.LoadScene("Black_Water_Cave", LoadSceneMode.Single);
    }

    public void LoadBlindMans()
    {
        StartCoroutine(DelayBlindMans());
    }

    private IEnumerator DelayBlindMans()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        SceneManager.LoadScene("Blind_Mans_Lagoon", LoadSceneMode.Single);
    }
    #endregion
}
