using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialogue_Manager : MonoBehaviour
{
    #region Variables
    [Header("Manager")]
    [SerializeField] private float timeBeforeLoad = 0.5f;

    [SerializeField] private AudioSource btnSound;

    [Header("Text parameters")]
    [SerializeField] private string[] lines;
    [SerializeField] private float textSpeed;
    [SerializeField] private float timeStartTextDialogue = 0.5f;

    [SerializeField] TextMeshProUGUI textComponent;

    private int _index;
    #endregion
	
	#region Builtin Methods
    void Start()
    {
        textComponent.text = string.Empty;
        StartCoroutine(StartTextDialogue());
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[_index])
            {
                NextLine();
            }
        }
    }
    //Scrolling of the text when the mouse start to moove
    #endregion

    #region Custom Methods
    public void StartDialogue()
    {
        StartCoroutine(TypeLine());
        _index = 0;
    }

    private IEnumerator TypeLine()
    {
        foreach(char c in lines[_index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
    //Increment of letters by time

    private void NextLine()
    {
        if(_index < lines.Length - 1)
        {
            _index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    private IEnumerator StartTextDialogue()
    {
        yield return new WaitForSeconds(timeStartTextDialogue);
        StartDialogue();
    }

    public void LoadNext()
    {
        StartCoroutine(TimeBeforeLoadNext());
    }

    private IEnumerator TimeBeforeLoadNext()
    {
        btnSound.Play();
        yield return new WaitForSeconds(timeBeforeLoad);
        SceneManager.LoadScene("Seller", LoadSceneMode.Single);
    }
    //Change pannel when the texte is done
    #endregion
}