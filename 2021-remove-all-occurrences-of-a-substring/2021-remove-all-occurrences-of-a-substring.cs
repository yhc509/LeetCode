using System.Text.RegularExpressions;

public class Solution {
    public string RemoveOccurrences(string s, string part) {
        string result = s;
        string t = null;
        var regex = new Regex(Regex.Escape(part));
        while(result != t) {
            t = result;
            result = regex.Replace(result, "", 1);
        }
        return result;
    }
}