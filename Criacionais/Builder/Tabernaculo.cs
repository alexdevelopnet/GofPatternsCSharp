using System.Text;

namespace GoFPatternsCSharp.Builder
{
    public class Tabernaculo
    {
        public string Estrutura { get; set; } = "";
        public string Altar { get; set; } = "";
        public string Arca { get; set; } = "";
        public string Cortinas { get; set; } = "";

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Tabernáculo construído:");
            sb.AppendLine($"- Estrutura: {Estrutura}");
            sb.AppendLine($"- Altar: {Altar}");
            sb.AppendLine($"- Arca: {Arca}");
            sb.AppendLine($"- Cortinas: {Cortinas}");
            return sb.ToString();
        }
    }
}