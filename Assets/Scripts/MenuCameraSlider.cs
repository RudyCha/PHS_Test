using UnityEngine;
using System.Collections;

public class MenuCameraSlider : MonoBehaviour
{
    public float slideDuration = 0.6f; // Time it takes to complete the slide
    public AnimationCurve easingCurve = AnimationCurve.EaseInOut(0, 0, 1, 1); // Smooth easing
    private Coroutine slideCoroutine;

    public void GoToCanvas(int canvasIndex)
    {
        float canvasWidth = Camera.main.orthographicSize * 2 * Camera.main.aspect;
        Vector3 targetPos = new Vector3(canvasIndex * canvasWidth, transform.position.y, transform.position.z);

        if (slideCoroutine != null)
            StopCoroutine(slideCoroutine);

        slideCoroutine = StartCoroutine(SmoothSlide(targetPos));
    }

    private IEnumerator SmoothSlide(Vector3 targetPosition)
    {
        Vector3 startPos = transform.position;
        float timeElapsed = 0f;

        while (timeElapsed < slideDuration)
        {
            float t = timeElapsed / slideDuration;
            float easedT = easingCurve.Evaluate(t);
            transform.position = Vector3.Lerp(startPos, targetPosition, easedT);
            timeElapsed += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition; // Ensure final accuracy
    }
}
