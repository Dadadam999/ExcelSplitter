namespace ExcelSplitter
{
    public class Rule
    {
        public int id { get; set; }
        public string Name { get; set; }
        public ExcelCell StartRange { get; set; }
        public ExcelCell EndRange { get; set; }
        public int SafeMethod { get; set; } = 0;
        public bool HasShowTitle { get; set; } = false;
    }
}
