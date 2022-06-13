namespace Data

{
    public class FreqAnalysis
    {
        public static Dictionary<string, int> FreqAnalysisFromString(string input) 
        { 
            Dictionary<string, int> dict = new Dictionary<string, int>();
            input.Replace(".", " ");
            input.Replace(",", string.Empty);
            input.Replace(":", " ");
            string[] words = input.Split(' ',StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries );
            

            List<string> listWithoutDuplicates = words.Distinct().ToList();
            var q = from x in words
                    group x by x into g
                    let count = g.Count()
                    orderby count descending
                    select new {Value = g.Key, Count = count};
            foreach (var x in q) {
               
                dict.Add(key:x.Value, value: x.Count);

              
            }


            return dict;
        }

        public static async Task<Dictionary<string, int>> FreqAnalysisForURL(string url)
        {
            HttpClient httpClient = new HttpClient();
            var content1 = await httpClient.GetStringAsync(url);
           
            return FreqAnalysisFromString(content1);
        }

        // public static async Task<List<string>> FreqAnalysisForURL(string url) 
        // {
        //HttpClient httpClient = new HttpClient();
        //     var content = await httpClient.GetStringAsync(url);
        //     return FreqAnalysisFromString(content);
        // }

        public static Dictionary<string, int> FreqAnalysisForFile(string file)
        {
            var content = File.ReadAllText(file);
            return FreqAnalysisFromString(content);


        }


    }
}