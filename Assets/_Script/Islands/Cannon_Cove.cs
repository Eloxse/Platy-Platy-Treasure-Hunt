using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cannon_Cove : MonoBehaviour
{
    #region Variables
    [SerializeField] private float _timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource _btnSound;
    [SerializeField] private GameObject _panDialogue2, _panDialogue3;
    [SerializeField] private GameObject _imgBackgournd, _imgMutiny;
    #endregion
	
	#region Properties
    #endregion
	
	#region Builtin Methods
    void Start()
    {
        
    }
    #endregion

    #region Custom Methods
    public void LoadBoulderClay()
    {
        StartCoroutine(DelayBoulderClay());
    }

    private IEnumerator DelayBoulderClay()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        SceneManager.LoadScene("Boulder_Clay", LoadSceneMode.Single);
    }

    public void LoadMutiny()
    {
        StartCoroutine(DelayMutiny());
    }

    private IEnumerator DelayMutiny()
    {
        _btnSound.Play();
        yield return new WaitForSeconds(_timeBeforeLoad);
        _panDialogue2.SetActive(false);
        _panDialogue3.SetActive(true);
        _imgBackgournd.SetActive(true);
        _imgMutiny.SetActive(true);
    }
    #endregion
}
