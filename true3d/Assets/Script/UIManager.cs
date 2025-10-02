using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI pontuacaoTexto;

    void Update()
    {
        pontuacaoTexto.text = "Pontuação: " + GameManager.pontuacao.ToString();
    }
}
