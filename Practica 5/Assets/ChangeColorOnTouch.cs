using UnityEngine;

public class ChangeColorOnTouch : MonoBehaviour
{
    // Variable para almacenar el Renderer del modelo
    private Renderer modelRenderer;

    // Arreglo de colores con más colores predefinidos y personalizados
    public Color[] colors = new Color[] {
        Color.red,        // Rojo
        Color.green,      // Verde
        Color.blue,       // Azul
        Color.yellow,     // Amarillo
        Color.cyan,       // Cian
        Color.magenta    // Magenta
    };

    // Índice para rastrear el color actual
    private int currentColorIndex = 0;

    void Start()
    {
        // Obtener el Renderer del modelo 3D
        modelRenderer = GetComponent<Renderer>();

        // Asegurarse de que haya colores en el arreglo
        if (colors.Length == 0)
        {
            Debug.LogError("No se han asignado colores al arreglo.");
        }
    }

    void Update()
    {
        // Detectar si la pantalla ha sido tocada
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            // Cambiar el color del material
            ChangeColor();
        }
    }

    void ChangeColor()
    {
        // Cambiar al siguiente color en el arreglo
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
        modelRenderer.material.color = colors[currentColorIndex];
    }
}
