using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightTime : MonoBehaviour
{
    public Transform sunTransform; // Assign the MainLight (Sun) transform here
    public float dayDuration = 60f; // Duration of daytime in seconds
    public float nightDuration = 30f; // Duration of nighttime in seconds

    private float _currentRotation = 0f;
    private float _rotationSpeed;

    private void Start()
    {
        _currentRotation = sunTransform.rotation.x;

        // Calculate the rotation speed based on the total rotation angle and duration
        _rotationSpeed = 360f / (dayDuration + nightDuration);
    }

    private void Update()
    {
        // Calculate the new rotation angle
        _currentRotation += _rotationSpeed * Time.deltaTime;

        // Wrap the rotation angle between 0 and 360 degrees
        _currentRotation %= 360f;

        // Set the rotation of the MainLight (Sun)
        sunTransform.rotation = Quaternion.Euler(_currentRotation, 0f, 0f);

        //// Check if it's daytime or nighttime and adjust the intensity/color of the light accordingly
        //if (currentRotation < 180f) // Daytime
        //{
        //    float intensity = Mathf.Lerp(0f, 1f, currentRotation / 180f);
        //    sunTransform.GetComponent<Light>().intensity = intensity;
        //    sunTransform.GetComponent<Light>().color = Color.Lerp(Color.black, Color.white, intensity);
        //}
        //else // Nighttime
        //{
        //    float intensity = Mathf.Lerp(1f, 0f, (currentRotation - 180f) / 180f);
        //    sunTransform.GetComponent<Light>().intensity = intensity;
        //    sunTransform.GetComponent<Light>().color = Color.Lerp(Color.white, Color.black, intensity);
        //}
    }
}
