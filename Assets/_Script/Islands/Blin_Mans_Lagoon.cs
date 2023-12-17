using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blin_Mans_Lagoon : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource _btnSound;
    [SerializeField] private GameObject _panDialogue2, _panDialogue3, _panDialogue4, _panDialogue5, _panDialogue6, _panDialogue7;
    [SerializeField] private GameObject _imgBackground, _imgMap, _imgPrincess, _imgTreasure, _imgTooLate;
    [SerializeField] private GameObject _btnCannon, _btnBoulder, _btnBlindMans, _btnBooty;
    #endregion
	
	#region Properties
    #endregion
	
	#region Builtin Methods
    void Start()
    {
        
    }
	#endregion

    #region Custom Methods
    public void GoingBack(){
        StartCoroutine(DelayGoingBack());
    }

    private IEnumerator DelayGoingBack(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue2.SetActive(false);
        _panDialogue3.SetActive(true);
        _imgBackground.SetActive(true);
        _imgMap.SetActive(true);
        _btnBoulder.SetActive(true);
        _btnCannon.SetActive(true);
        _btnBlindMans.SetActive(true);
        _btnBooty.SetActive(true);
    }

    public void LoadCannonCove(){
        StartCoroutine(DelayCannonCove());
    }

    private IEnumerator DelayCannonCove(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        SceneManager.LoadScene("Cannon_Cove", LoadSceneMode.Single);
    }

    public void LoadBoulderClay(){
        StartCoroutine(DelayBoulderClay());
    }

    private IEnumerator DelayBoulderClay(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue3.SetActive(false);
        _btnBlindMans.SetActive(false);
        _btnBooty.SetActive(false);
        _btnBoulder.SetActive(false);
        _btnCannon.SetActive(false);
        _panDialogue4.SetActive(true);
        _imgBackground.SetActive(true);
        _imgPrincess.SetActive(true);
    }

    public void Landing(){
        StartCoroutine(DelayLanding());
    }

    private IEnumerator DelayLanding(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue2.SetActive(false);
        _panDialogue5.SetActive(true);
    }

    public void Forest(){
        StartCoroutine(DelayForest());
    }

    private IEnumerator DelayForest(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue5.SetActive(false);
        _panDialogue6.SetActive(true);
        _imgBackground.SetActive(true);
        _imgTreasure.SetActive(true);
    }

    public void Beach(){
        StartCoroutine(DelayBeach());
    }

    private IEnumerator DelayBeach(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue5.SetActive(false);
        _panDialogue7.SetActive(true);
        _imgBackground.SetActive(true);
        _imgTooLate.SetActive(true);
    }
    #endregion
}