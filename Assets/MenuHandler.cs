using System;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class MenuHandler : MonoBehaviour
{
    private GroupBox mainPanel, optionsPanel;
    private Button startBtn, optionsBtn, quitBtn;

    // Pause Menu
    private KeyCode pauseKey = KeyCode.Escape;
    private GroupBox PauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // Panel
        mainPanel = root.Q<GroupBox>("MAINMENU");
        optionsPanel = root.Q<GroupBox>("OPTIONPANEL");
        PauseMenu = root.Q<GroupBox>("PAUSEMENU");

        // MainPanel Buttons
        startBtn = root.Q<Button>("StartBtn");
        optionsBtn = root.Q<Button>("OptionsBtn");
        quitBtn = root.Q<Button>("QuitBtn");

        startBtn.RegisterCallback<ClickEvent>(OnStartButtonClick);
        optionsBtn.RegisterCallback<ClickEvent>(OnOptionsButtonClick);
        quitBtn.RegisterCallback<ClickEvent>(OnQuitButtonClick);

        root.Q<Button>("BACK").RegisterCallback<ClickEvent>(OnBackButtonClick);

        PauseMenu.style.display = DisplayStyle.None;
        optionsPanel.style.display = DisplayStyle.None;

    }

    private void Update()
    {
        var noActivePanel = mainPanel.style.display == DisplayStyle.None && optionsPanel.style.display == DisplayStyle.None;

        if (Input.GetKeyDown(pauseKey) && noActivePanel)
        {
            PauseMenu.style.display = DisplayStyle.Flex;
            Debug.Log("Esc Button Click");
        }


    }

    private void OnBackButtonClick(ClickEvent evt)
    {
        PauseMenu.style.display = DisplayStyle.None;
    }

    private void OnStartButtonClick(ClickEvent evt)
    {
        Debug.Log("Start Button Clicked");
    }

    private void OnOptionsButtonClick(ClickEvent evt)
    {
        Debug.Log("Options Button Clicked");
        mainPanel.style.display = DisplayStyle.None;
        optionsPanel.style.display = DisplayStyle.Flex;
    }

    private void OnQuitButtonClick(ClickEvent evt)
    {
        Application.Quit();
        Debug.Log("Quit Button Clicked");
    }
}
