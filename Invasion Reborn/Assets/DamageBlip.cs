using UnityEngine;
using System.Collections; // Import the System.Collections namespace for IEnumerator

public class DamageBlip : MonoBehaviour
{
    public float beatScale = 1.2f; // Scale factor when beating
    public float beatDuration = 0.2f; // Duration of the beat

    private Vector3 originalScale; // Original scale of the object

    void Start()
    {
        // Store the original scale of the object
        originalScale = transform.localScale;

        

    }

    public void TakeDamage()
    {
        StartCoroutine(Blip());
    }

    IEnumerator Blip()
    {
        // Scale up smoothly
        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime / (beatDuration / 2);
            transform.localScale = Vector3.Lerp(originalScale, originalScale * beatScale, t);
            yield return null;
        }

        // Scale down smoothly
        t = 0;
        while (t < 1)
        {
            t += Time.deltaTime / (beatDuration / 2);
            transform.localScale = Vector3.Lerp(originalScale * beatScale, originalScale, t);
            yield return null;
        }
    }
}
