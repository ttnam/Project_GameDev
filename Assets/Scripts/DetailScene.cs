#region Namespaces

using UnityEngine;
using System.Collections;
using Assets.Scripts.Globals;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

#endregion // Namespaces

public class DetailScene : MonoBehaviour
{

    #region Variables

    // Canvas
    public Canvas m_Canvas;

    // GUIAnimFREE object of dialogs
    public GUIAnimFREE m_Dialog;
    public GUIAnimFREE m_Dialog_Info;
    public GUIAnimFREE m_DialogButtons;


    // Data
    [SerializeField]
    private GameObject WonderName;
    [SerializeField]
    private GameObject WonderNation;
    #endregion // Variables


    #region MonoBehaviour

    void Awake()
    {
        if (enabled)
        {
            // Set GUIAnimSystemFREE.Instance.m_AutoAnimation to false in Awake() will let you control all GUI Animator elements in the scene via scripts.
            GUIAnimSystemFREE.Instance.m_AutoAnimation = false;
        }
    }

    void Start()
    {

        StartCoroutine(MoveInTitleGameObjects());


        GUIAnimSystemFREE.Instance.SetGraphicRaycasterEnable(m_Canvas, false);

        onLoadData();

    }

    // Update is called every frame, if the MonoBehaviour is enabled.
    // http://docs.unity3d.com/ScriptReference/MonoBehaviour.Update.html
    void Update()
    {

    }

    #endregion // MonoBehaviour

    // ########################################
    // MoveIn/MoveOut functions
    // ########################################

    #region MoveIn/MoveOut

    // MoveIn m_Title1 and m_Title2
    IEnumerator MoveInTitleGameObjects()
    {
        yield return new WaitForSeconds(1.0f);

        // MoveIn all dialogs and buttons
        StartCoroutine(MoveInPrimaryButtons());
    }

    // MoveIn all dialogs and buttons
    IEnumerator MoveInPrimaryButtons()
    {
        yield return new WaitForSeconds(1.0f);

        // MoveIn all dialogs
        m_Dialog.MoveIn(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);
        m_Dialog_Info.MoveIn(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);
        m_DialogButtons.MoveIn(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);

        // Enable all scene switch buttons
        StartCoroutine(EnableAllDemoButtons());
    }

    // MoveOut all dialogs and buttons
    public void HideAllGUIs()
    {
        // MoveOut all dialogs
        m_Dialog.MoveOut(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);
        m_Dialog_Info.MoveOut(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);
        m_DialogButtons.MoveOut(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);


        // MoveOut m_Title1 and m_Title2
        StartCoroutine(HideTitleTextMeshes());
    }

    // MoveOut m_Title1 and m_Title2
    IEnumerator HideTitleTextMeshes()
    {
        yield return new WaitForSeconds(1.0f);

    }

    #endregion // MoveIn/MoveOut

    // ########################################
    // Enable/Disable button functions
    // ########################################

    #region Enable/Disable buttons

    // Enable/Disable all scene switch Coroutine
    IEnumerator EnableAllDemoButtons()
    {
        yield return new WaitForSeconds(1.0f);

        // Enable all scene switch buttons
        // http://docs.unity3d.com/Manual/script-GraphicRaycaster.html
        GUIAnimSystemFREE.Instance.SetGraphicRaycasterEnable(m_Canvas, true);
    }

    // Disable all buttons for a few seconds
    IEnumerator DisableButtonForSeconds(GameObject GO, float DisableTime)
    {
        // Disable all buttons
        GUIAnimSystemFREE.Instance.EnableButton(GO.transform, false);

        yield return new WaitForSeconds(DisableTime);

        // Enable all buttons
        GUIAnimSystemFREE.Instance.EnableButton(GO.transform, true);
    }

    #endregion // Enable/Disable buttons

    // ########################################
    // UI Responder functions
    // ########################################

    #region UI Responder

    public void OnDialogButton()
    {
        // MoveOut m_Dialog
        m_Dialog.MoveOut(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);
        m_Dialog_Info.MoveOut(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);
        m_DialogButtons.MoveOut(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);

        // Disable m_DialogButtons for a few seconds
        StartCoroutine(DisableButtonForSeconds(m_DialogButtons.gameObject, 2.0f));

        // Moves m_Dialog back to screen
        StartCoroutine(DialogMoveIn());
    }

    #endregion // UI Responder

    // ########################################
    // Move Dialog/Button functions
    // ########################################

    #region Move Dialog/Button

    // Moves m_Dialog back to screen
    IEnumerator DialogMoveIn()
    {
        yield return new WaitForSeconds(1.5f);

        m_Dialog.MoveIn(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);
        m_Dialog_Info.MoveIn(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);
        m_DialogButtons.MoveIn(GUIAnimSystemFREE.eGUIMove.SelfAndChildren);
    }

    #endregion // Move Dialog/Button


    #region CUSTOM

    private void onLoadData()
    {
        int currWonder = Global.CURR_WONDER;
        Debug.LogError("ID: " + currWonder);
        Wonder wonder = WonderManager.getInstance().getWonder(currWonder);
        if (wonder != null)
        {
            WonderName.GetComponent<Text>().text = wonder.getName();
            WonderNation.GetComponent<Text>().text = wonder.getNation();
        }

    }

    public void OnHome()
    {
        SceneManager.LoadScene(Global.SPLASH_SCENE);
    }
    public void OnBack()
    {
        SceneManager.LoadScene(Global.MAIN_SCENE);
    }

    #endregion
}
