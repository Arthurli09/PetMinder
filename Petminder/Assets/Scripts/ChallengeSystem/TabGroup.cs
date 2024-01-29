using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;
    public TabButton selectedTab;
    public List<GameObject> objectsToSwap;

    public Color32 unselectedColor;
    public Color32 hoverColor;
    public Color32 selectedColor;

    public void Subscribe(TabButton button) {
        if (tabButtons == null) {
            tabButtons = new List<TabButton>();
            selectedTab = button;
        }
        tabButtons.Add(button);

        // Update the UI display, so that only the first tab shows
    }

    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        if (selectedTab == null || button != selectedTab) {
            button.background.GetComponent<Image>().color = hoverColor;
        }
    }

    public void OnTabExit(TabButton button) {
        ResetTabs();
    }

    public void OnTabSelected(TabButton button) {
        selectedTab = button;

        ResetTabs();

        button.background.GetComponent<Image>().color = selectedColor;
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < objectsToSwap.Count; i++) {
            if (i == index)
            {
                objectsToSwap[i].SetActive(true);
            }
            else {
                objectsToSwap[i].SetActive(false);
            }
        }
    } 

    public void ResetTabs() {
        foreach (TabButton button in tabButtons) {
            if (selectedTab != null && button == selectedTab) {
                continue;
            }
            button.background.GetComponent<Image>().color = unselectedColor;
        }
    }
}
