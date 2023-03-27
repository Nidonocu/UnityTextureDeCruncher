using System.IO;
using UnityEditor;
using UnityEngine;

/**
 * Performs automatic search and turns off crunch compression setting on all texture files
 * 
 * Created by Nidonocu and Bing AI 2023
 * 
 * See README and LICENCE for more details.
 */

public class DeCrunchTextures : MonoBehaviour
{
    [MenuItem("Tools/Turn Off Crunch Compression")]
    public static void TurnOffCrunchCompression()
    {
        string[] extensions = new string[] { "*.tga", "*.png", "*.jpg", "*.psd" };
        int totalFiles = 0;
        foreach (string extension in extensions)
        {
            string[] textureFiles = Directory.GetFiles(Application.dataPath, extension, SearchOption.AllDirectories);
            totalFiles += textureFiles.Length;
        }

        int processedFiles = 0;
        foreach (string extension in extensions)
        {
            string[] textureFiles = Directory.GetFiles(Application.dataPath, extension, SearchOption.AllDirectories);
            foreach (string textureFile in textureFiles)
            {
                string relativePath = "Assets" + textureFile.Substring(Application.dataPath.Length);
                TextureImporter textureImporter = AssetImporter.GetAtPath(relativePath) as TextureImporter;
                if (textureImporter != null)
                {
                    textureImporter.crunchedCompression = false;
                    textureImporter.SaveAndReimport();
                }
                processedFiles++;
                EditorUtility.DisplayProgressBar("Turning Off Crunch Compression", "Processing file " + processedFiles + " of " + totalFiles, (float)processedFiles / totalFiles);
            }
        }
        EditorUtility.ClearProgressBar();
    }
}
