using UnityEngine;

public class PixelArtGenerator : MonoBehaviour
{
    public int textureWidth = 16;
    public int textureHeight = 16;
    public Color primaryColor = Color.white;
    public Color secondaryColor = Color.black;
    public Color tertiaryColor = Color.red;

    private Texture2D texture;

    void Start()
    {
        texture = new Texture2D(textureWidth, textureHeight);
        GenerateRandomPixelArt();
        ApplyTexture();
    }

    void GenerateRandomPixelArt()
    {
        for (int x = 0; x < textureWidth; x++)
        {
            for (int y = 0; y < textureHeight; y++)
            {
                Color color = GetRandomColor(x, y);
                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();
    }

    Color GetRandomColor(int x, int y)
    {
        int randomValue = Random.Range(0, 3);
        switch (randomValue)
        {
            case 0:
                return primaryColor;
            case 1:
                return secondaryColor;
            case 2:
                return tertiaryColor;
            default:
                return Color.white;
        }
    }

    void ApplyTexture()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.mainTexture = texture;
        }
    }

    public void GeneratePattern(string patternType)
    {
        switch (patternType)
        {
            case "Checkerboard":
                GenerateCheckerboardPattern();
                break;
            case "Stripes":
                GenerateStripesPattern();
                break;
            case "Gradient":
                GenerateGradientPattern();
                break;
            default:
                GenerateRandomPixelArt();
                break;
        }
        ApplyTexture();
    }

    void GenerateCheckerboardPattern()
    {
        for (int x = 0; x < textureWidth; x++)
        {
            for (int y = 0; y < textureHeight; y++)
            {
                Color color = (x + y) % 2 == 0 ? primaryColor : secondaryColor;
                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();
    }

    void GenerateStripesPattern()
    {
        for (int x = 0; x < textureWidth; x++)
        {
            Color color = x % 2 == 0 ? primaryColor : secondaryColor;
            for (int y = 0; y < textureHeight; y++)
            {
                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();
    }

    void GenerateGradientPattern()
    {
        for (int x = 0; x < textureWidth; x++)
        {
            for (int y = 0; y < textureHeight; y++)
            {
                float t = (float)x / (textureWidth - 1);
                Color color = Color.Lerp(primaryColor, secondaryColor, t);
                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();
    }
}