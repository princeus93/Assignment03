using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;


public class DropDownLiveSelect : MonoBehaviour
{
    public Text livesTextBox;
    public static int livesSelected;

    public void Start()
    {
        var dropdown = transform.GetComponent<Dropdown>();

        dropdown.options.Clear();

        List<int> items = new List<int>();
        items.Add(0);
        items.Add(1);
        items.Add(2);
        items.Add(3);

        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item.ToString() });
        }
        dropdown.onValueChanged.AddListener(delegate { DropdownItemSelected(dropdown); }); 
    }

    void DropdownItemSelected(Dropdown dropdown)
    {
        int index = dropdown.value;

        livesTextBox.text = dropdown.options[index].text;
        livesSelected = index;
    }
}
