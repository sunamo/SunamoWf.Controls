using System.Text;

namespace SunamoWf.Controls._sunamo.SunamoWfHelpers;

/// <summary>
/// Minimal picture description helper used by DisplayImageUC.
/// </summary>
internal static class PictureInfo
{
    /// <summary>
    /// Returns a short text with the width and height of the bitmap.
    /// </summary>
    internal static string InfoAbout(Bitmap bitmap)
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.AppendLine("Width: " + bitmap.Width);
        stringBuilder.AppendLine("Height: " + bitmap.Height);
        return stringBuilder.ToString();
    }
}
