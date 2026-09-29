using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class Exercise03 : MonoBehaviour
{
    public string nameToAdd = "";
    public int slotToRelease = 1;
    public string searchText = "";

    string[] menuItems =
    {
        "Add the beast named in the Inspector",
        "List all beasts",
        "Release the beast in the Inspector slot",
        "Search for a beast by name",
        "Quit"
    };

    List<string> storage = new List<string>();
    bool isRunning = true;

    void Start()
    {
        Debug.Log("=== PROFESSOR LIGHT PC ===");
        PrintMenu();
    }

    void Update()
    {
        if (!isRunning) return;

        int choice = ReadChoice();
        if (choice == 0) return;

        switch (choice)
        {
            case 1:
                AddBeast(nameToAdd);
                break;
            case 2:
                ListBeasts();
                break;
            case 3:
                ReleaseBeast(slotToRelease);
                break;
            case 4:
                SearchBeast(searchText);
                break;
            case 5:
                Quit();
                break;
            default:
                Debug.LogWarning("Unknown option: " + choice);
                break;
        }

        if (isRunning) PrintMenu();
    }

    void PrintMenu()
    {
        string menu = "";
        for (int i = 0; i < menuItems.Length; i++)
        {
            menu = menu + (i + 1) + ") " + menuItems[i] + "\n";
        }
        Debug.Log(menu);
    }

    int ReadChoice()
    {
        if (Keyboard.current == null) return 0;

        if (Keyboard.current.digit1Key.wasPressedThisFrame) return 1;
        if (Keyboard.current.digit2Key.wasPressedThisFrame) return 2;
        if (Keyboard.current.digit3Key.wasPressedThisFrame) return 3;
        if (Keyboard.current.digit4Key.wasPressedThisFrame) return 4;
        if (Keyboard.current.digit5Key.wasPressedThisFrame) return 5;
        return 0;
    }

    void AddBeast(string name)
    {
        name = name.Trim().ToUpper();
        if (name == "")
        {
            Debug.LogWarning("Type a name in the Inspector first.");
            return;
        }
        storage.Add(name);
        Debug.Log(name + " was sent to the PC. The PC now holds " + storage.Count + " beast(s).");
    }

    void ListBeasts()
    {
        if (storage.Count == 0)
        {
            Debug.Log("The PC is empty.");
            return;
        }
        string list = "";
        for (int i = 0; i < storage.Count; i++)
        {
            list = list + (i + 1) + ") " + storage[i] + "\n";
        }
        Debug.Log(list);
    }

    void ReleaseBeast(int slot)
    {
        if (slot < 1 || slot > storage.Count)
        {
            Debug.Log("There is no beast in slot " + slot + ".");
            return;
        }
        string released = storage[slot - 1];
        storage.RemoveAt(slot - 1);
        Debug.Log(released + " was released. Bye, " + released + "!");
    }

    void SearchBeast(string text)
    {
        text = text.Trim().ToUpper();
        if (text == "")
        {
            Debug.LogWarning("Type text to search for first.");
            return;
        }
        string results = "";
        int found = 0;
        for (int i = 0; i < storage.Count; i++)
        {
            if (storage[i].Contains(text))
            {
                results = results + (i + 1) + ") " + storage[i] + "\n";
                found = found + 1;
            }
        }
        if (found == 0)
        {
            Debug.Log("No beast matches: " + text);
        }
        else
        {
            Debug.Log(results);
        }
    }

    void Quit()
    {
        Debug.Log("Goodbye! The PC holds " + storage.Count + " beast(s).");
        isRunning = false;
    }
}
