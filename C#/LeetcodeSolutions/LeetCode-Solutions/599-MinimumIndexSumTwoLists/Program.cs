public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        var dict1 = new Dictionary<string, int>();
        var dict2 = new Dictionary<string, int>();
        for(int i = 0; i < list1.Length; i++) dict1[list1[i]] = i;
        for(int i = 0; i < list2.Length; i++) dict2[list2[i]] = i;
        var list = new List<string>(); int count = int.MaxValue;
        foreach(var item in dict1)
        {
            if (dict2.ContainsKey(item.Key))
            {
                if (item.Value + dict2[item.Key] < count)
                {
                    list.Clear();
                    list.Add(item.Key);
                    count = item.Value + dict2[item.Key];
                }
                else if (item.Value + dict2[item.Key] == count)
                    list.Add(item.Key);
            }
        }
        return list.ToArray();
    }
}