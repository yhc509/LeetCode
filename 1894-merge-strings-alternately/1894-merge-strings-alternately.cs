public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int i = 0;
        int j = 0;
        StringBuilder sb = new StringBuilder();

        while(i < word1.Length || i < word2.Length) {
            if(i < word1.Length) sb.Append(word1[i]);
            if(i < word2.Length) sb.Append(word2[i]);
            i++;
        }
        return sb.ToString();
    }
}