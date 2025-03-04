using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UILoading : MonoBehaviour
{
    public Text loadingText; // Reference to the text component to show loading percentage
    public float loadingDuration = 5f; // How long it takes to reach 100%

    private void Start()
    {
        // Start the loading process
        StartCoroutine(LoadAndDisplay());
    }

    private IEnumerator LoadAndDisplay()
    {
        // Animate the loading from 0% to 100%
        float timeElapsed = 0f;
        while (timeElapsed < loadingDuration)
        {
            float progress = Mathf.Clamp01(timeElapsed / loadingDuration); // Calculate the loading progress (0 to 1)
            loadingText.text = (progress * 100f).ToString("F0") + "%"; // Update the text to show the percentage
            timeElapsed += Time.deltaTime;
            yield return null;
        }
        loadingText.text = "100%"; // Ensure it says 100% at the end
    }
}
