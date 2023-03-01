namespace MoneyExtension;
    
public static class Money 
{
    public static int ToCents(this decimal amount)
    {
        if (amount <= 0)
            return 0;

        var valeu = amount.ToString("N2").Replace(",", "").Replace(".", "");
        
        if (string.IsNullOrEmpty(valeu))
            return 0;

        int.TryParse(valeu, out var result);
        return result;
    }
}
