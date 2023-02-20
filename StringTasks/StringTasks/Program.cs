internal class Program {
    private static void Main(string[] args) {
        Console.WriteLine("Hello, World!");
    }

    //Учитывая две строки ransom Note и magazine, верните true,
    //если ransomNote может быть создан с использованием букв из magazine, и false в противном случае.
    // 383. Ransom Note
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        for(int i = 0; i < magazine.Length; i++) {
            if(!map.ContainsKey(magazine[i]))
                map.Add(magazine[i], 1);
            else
                map[magazine[i]]++;
        }
        for(int i = 0; i < ransomNote.Length; i++) {
            if(!map.ContainsKey(ransomNote[i]) || map[ransomNote[i]] == 0)
                return false;
            map[ransomNote[i]]--;
        }
        return true;
    }


    // Первый уникальный символ в строке 387
    public int FirstUniqChar(string s) {
        var map = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++) {
            if(map.ContainsKey(s[i]))
                map[s[i]] = -1;
            else
                map.Add(s[i], i);
        }
        int res = int.MaxValue;
        foreach(int num in map.Values) {
            if(num != -1 && res > num) {
                res = num;
            }
        }
        if(res == int.MaxValue) {
            res = -1;
        }
        return res;
    }

    //242. Valid Anagram
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++) {
            if(!map.ContainsKey(s[i]))
                map.Add(s[i], 1);
            else
                map[s[i]]++;
        }
        for(int i = 0; i < t.Length; i++) {
            if(!map.ContainsKey(t[i]) || map[t[i]] == 0)
                return false;
            map[t[i]]--;
            if(map[t[i]] == 0)
                map.Remove(t[i]);
        }
        if(map.Count != 0)
            return false;
        return true;
    }
}