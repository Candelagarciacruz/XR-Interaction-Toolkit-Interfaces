using UnityEngine;
using TMPro;

public class ActualizeUI : MonoBehaviour {

    public TextMeshProUGUI textUI;
    
    public void ActualizeText() {
        textUI.text = "Objeto agarrado";
    }
}
