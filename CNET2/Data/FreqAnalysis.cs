namespace Data
{
    public class FreqAnalysis
    {
        public static Dictionary<string, int> FreqAnalysisFromString(string input) 
        {
            throw new NotFiniteNumberException();
        }

        public static async Task<Dictionary<string, int>> FreqAnalysisForURL(string url) 
        {
       HttpClient httpClient = new HttpClient();
            var content = await httpClient.GetStringAsync(url);
            return FreqAnalysisFromString(content);
        }

        public static Dictionary<string, int> FreqAnalysisForFile(string file) 
        {
            var content = File.ReadAllText(file);
        return     FreqAnalysisFromString(content);

      
        }


    }
}