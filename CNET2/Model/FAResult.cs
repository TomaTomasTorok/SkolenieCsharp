namespace Model
{
    /// <summary>
    /// Výsledok frekvenčnej analýzy pre jeden zdroj (súbor alebo URL)
    /// </summary>
    public class FAResult
    {
 public FAResult(string source, SourceType sourceType)
        {
            Source = source;
            SourceType = sourceType;
           
            
        }
        public FAResult() { }

        /// <summary>
        /// zdroj textu
        /// </summary>
        public string Source { get; set; } 
        public SourceType  SourceType { get; set; } 
        /// <summary>
        /// Vysledna frekvenc. anal
        /// </summary>
        public  Dictionary<string, int> Words { get; set; }=new Dictionary<string, int>();
        public override string ToString()
        {
            return $"{Source} {Words?.Count}";
        }
        public Dictionary<string, int> GetTop10() => (Dictionary<string, int>) Words.OrderByDescending(kv => kv.Value).Take(10)
            .ToDictionary(kv => kv.Key, kv => kv.Value);
    }
    public enum SourceType 
    {
        URL,
        FILE
    }
}