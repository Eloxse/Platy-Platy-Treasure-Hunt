using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder_Clay : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource _btnSound;
    [SerializeField] private GameObject _imgBackground, _imgMap;
    [SerializeField] private GameObject _vid;
    [SerializeField] private GameObject _panDialogue1, _panDialogue2;
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
    }
    #endregion
}
