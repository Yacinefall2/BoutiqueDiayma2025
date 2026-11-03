namespace P2FixAnAppDotNetCode.Models
{
    /// <summary>
    /// Affiche les prix en FCFA, quelle que soit la culture de l'utilisateur
    /// </summary>
    public static class PriceExtensions
    {
        public static string ToFcfa(this double price) => $"{price:N0} FCFA";
    }
}
