using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using UnityEngine.Rendering.VirtualTexturing;

public class IntroManager : MonoBehaviour
{
    public Image background;
    public TextMeshProUGUI introText;
    private GameObject system;
    private GameObject character;
    public Camera cameraIntro; // C�mera para a tela de introdu��o
    public Camera mainCamera; // C�mera principal do jogo
    public float duracaoFade = 2.0f; // Dura��o do fade out
    public float tempoDisplay = 5.0f; // Tempo para exibir a introdu��o

    public void Start()
    {
        system = GameObject.Find("GameSystem");
        character = GameObject.Find("Character");
        system.SetActive(false);
        character.SetActive(false);
        StartCoroutine(IntroSequence());
    }

    IEnumerator IntroSequence()
    {
        // Ativa a c�mera de introdu��o e desativa a c�mera principal
        cameraIntro.gameObject.SetActive(true);
        mainCamera.gameObject.SetActive(false);

        // Exibir a tela preta e o texto
        background.gameObject.SetActive(true);
        introText.gameObject.SetActive(true);

        // Esperar pelo tempo de exibi��o
        yield return new WaitForSeconds(tempoDisplay);

        // Iniciar o fade out
        yield return StartCoroutine(Fade());

        // Trocar para a c�mera principal do jogo
        cameraIntro.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);
        system.SetActive(true);
        character.SetActive(true);
    }

    IEnumerator Fade()
    {
        Color screenColor = background.color;
        Color textColor = introText.color;
        for (float t = 0.01f; t < duracaoFade; t += Time.deltaTime)
        {
            background.color = Color.Lerp(screenColor, new Color(screenColor.r, screenColor.g, screenColor.b, 0), Mathf.Min(1, t / duracaoFade));
            introText.color = Color.Lerp(textColor, new Color(textColor.r, textColor.g, textColor.b, 0), Mathf.Min(1, t / duracaoFade));
            yield return null;
        }

        background.gameObject.SetActive(false);
        introText.gameObject.SetActive(false);
    }
}
