using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blin_Mans_Lagoon : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource _btnSound;
    [SerializeField] private GameObject _panDialogue2, _panDialogue3;
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
    }
    #endregion
}
