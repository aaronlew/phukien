using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class StringUtils
{
    #region Public Methods

    public static string GetGoodUrl(string badUrl)
    {
        return badUrl.RemoveMarks().RemoveSpecialCharacters().ToLower();
    }

    static public string RemoveBadCode(this string input)
    {
        return input.RemoveBetween("<!--[if gte mso", "<!--[endif] -->");
    }

    static string RemoveBetween(this string input, char begin, char end)
    {
        var regex = new Regex(string.Format("\\{0}.*?\\{1}", begin, end));
        return regex.Replace(input, string.Empty);
    }

    static string RemoveBetween(this string input, string start, string end)
    {
        if (null == input) return null;

        string regex = string.Format("{0}(.*?){1}",
            Regex.Escape(start),
            Regex.Escape(end));

        string badCode = Regex.Matches(input, regex, RegexOptions.Singleline)
        .Cast<Match>()
        .Select(match => match.Groups[1].Value).FirstOrDefault();

        if (String.Empty != badCode)
        {
            badCode = start + badCode + end;
            return input.Replace(badCode, String.Empty);
        }

        return input;
    }

    static string RemoveSpecialCharacters(this string input)
    {
        var r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
        return r.Replace(input, String.Empty).SpaceToStroke();
    }

    static string RemoveMarks(this string input)
    {
        Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
        string strFormD = input.Normalize(System.Text.NormalizationForm.FormD);
        return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
    }

    //private static readonly string[] VietnameseSigns = new string[] {
    //                                      "aAeEoOuUiIdDyY",
    //                                      "áàạảãâấầậẩẫăắằặẳẵ",
    //                                      "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
    //                                      "éèẹẻẽêếềệểễ",
    //                                      "ÉÈẸẺẼÊẾỀỆỂỄ",
    //                                      "óòọỏõôốồộổỗơớờợởỡ",
    //                                      "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
    //                                      "úùụủũưứừựửữ",
    //                                      "ÚÙỤỦŨƯỨỪỰỬỮ",
    //                                      "íìịỉĩ",
    //                                      "ÍÌỊỈĨ",
    //                                      "đ",
    //                                      "Đ",
    //                                      "ýỳỵỷỹ",
    //                                      "ÝỲỴỶỸ"
    //                                     };

    //public static string RemoveSign4VietnameseString(string str)
    //{
    //    for (int i = 1; i < VietnameseSigns.Length; i++)
    //    {
    //        for (int j = 0; j < VietnameseSigns[i].Length; j++)
    //            str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
    //    }
    //    return str;
    //}
    #endregion

    #region Private Methods
    static string SpaceToStroke(this string input)
    {
        input = input.Replace(' ', '-');
        while (input.Contains("--"))
        {
            input = input.Replace("--", "-");
        }
        return input;
    }
    #endregion

}