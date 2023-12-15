using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boulder_Clay : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource _btnSound;
    [SerializeField] private GameObject _imgBackground, _imgMap;
    [SerializeField] private GameObject _vid;
    [SerializeField] private GameObject _panDialogue1, _panDialogue2, _panDialogue3, _panDialogue4;
    [SerializeField] private GameObject _btnBoulderClay, _btnCannonCove;
    #endregion
	
	#region Properties
    #endregion
	
	#region Builtin Methods
    void Start()
    {
        
    }
    #endregion

    #region Custom Methods
    public void Next()
    {
        StartCoroutine(DelayNext());
    }

    private IEnumerator DelayNext()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _imgBackground.SetActive(false);
        _imgMap.SetActive(false);
        _panDialogue1.SetActive(false);
        _btnBoulderClay.SetActive(false);
        _btnCannonCove.SetActive(false);
        _vid.SetActive(true);
        _panDialogue2.SetActive(true);
    }

    public void DontApproach()
    {
        StartCoroutine(DelayDontApproach());
    }

    private IEnumerator DelayDontApproach()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue2.SetActive(false);
        _panDialogue3 .SetActive(true);
    }

    public void Wait()
    {
        StartCoroutine(DelayWait());
    }

    private IEnumerator DelayWait()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue2 .SetActive(false);
        _panDialogue4 .SetActive(true);
    }

    public void BlackSand()
    {
        StartCoroutine(DelayBlackSand());
    }

    private IEnumerator DelayBlackSand()
    {
        _btnSound .Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        SceneManager.LoadScene("Black_Sand_Atoll", LoadSceneMode.Single);
    }
    #endregion
}
