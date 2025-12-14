using UnityEngine;
using UnityEngine.UI;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject[] panels; // An array of panels to switch between
    private int currentPanelIndex = 0; // The index of the currently active panel

    private void Start()
    {
        // Ensure that only the first panel is initially active
        ShowPanel(currentPanelIndex);
    }

    public void ShowNextPanel()
    {
        // Hide the current panel
        HidePanel(currentPanelIndex);

        // Increment the index to show the next panel (loop around if needed)
        currentPanelIndex = (currentPanelIndex + 1) % panels.Length;

        // Show the next panel
        ShowPanel(currentPanelIndex);
    }

    private void ShowPanel(int index)
    {
        // Ensure all panels are initially hidden
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(false);
        }

        // Show the panel at the specified index
        panels[index].SetActive(true);
    }

    private void HidePanel(int index)
    {
        // Hide the panel at the specified index
        panels[index].SetActive(false);
    }
}
