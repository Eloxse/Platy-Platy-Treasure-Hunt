using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cannon_Cove : MonoBehaviour
{
    #region Variables
    [Header("Manager")]
    [SerializeField] private float timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource btnSound;

    [Header("Images")]
    [SerializeField] private GameObject imgBackgournd;
    [SerializeField] private GameObject imgMutiny;

    [Header("Pannel")]
    [SerializeField] private GameObject panDial2;
    [SerializeField] private GameObject panDial3;
    #endregion

    #region Custom Methods
    public void LoadBoulderClay()
    {
        StartCoroutine(DelayBoulderClay());
    }

    private IEnumerator DelayBoulderClay()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Boulder_Clay", LoadSceneMode.Single);
    }

    public void LoadMutiny()
    {
        StartCoroutine(DelayMutiny());
    }

    private IEnumerator DelayMutiny()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        panDial2.SetActive(false);

        panDial3.SetActive(true);
        imgBackgournd.SetActive(true);
        imgMutiny.SetActive(true);
    }
    #endregion
}
