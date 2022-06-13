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
           
            ddddd
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
    }
    public enum SourceType 
    {
        URL,
        FILE
    }
}