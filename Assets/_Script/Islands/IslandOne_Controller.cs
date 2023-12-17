using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IslandOne_Controller : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource _btnSound;
    [SerializeField] private GameObject _panDialogue1, _panDialogue2, _panDialogue3, _panDialogue4;
    [SerializeField] private GameObject _btnChoice1, _btnChoice2;
    [SerializeField] private GameObject _imgClement, _imgBackground, _imgLost;
    #endregion
	
	#region Properties
    #endregion
	
	#region Builtin Methods
    void Start()
    {
        
    }
    #endregion

    #region Custom Methods
    public void NextPannel()
    {
        StartCoroutine(DelayNextPannel());
    }

    private IEnumerator DelayNextPannel()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue1.SetActive(false);
        _panDialogue2.SetActive(true);
    }

    public void ChoiceOne()
    {
        StartCoroutine(DelayChoiceOne());
    }

    private IEnumerator DelayChoiceOne()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue2.SetActive(false);
        _imgBackground.SetActive(true);
        _imgClement.SetActive(true);
        _panDialogue3.SetActive(true);
    }

    public void ChoiceTwo()
    {
        StartCoroutine(DelayChoiceTwo());
    }

    private IEnumerator DelayChoiceTwo()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        SceneManager.LoadScene("Chicken_Isle", LoadSceneMode.Single);
    }

    public void Lost(){
        StartCoroutine(DelayLost());
    }

    private IEnumerator DelayLost(){
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue3.SetActive(false);
        _imgClement.SetActive(false);
        _panDialogue4.SetActive(true);
        _imgLost.SetActive(true);
    }
    #endregion
}
