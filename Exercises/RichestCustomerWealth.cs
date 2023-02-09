//1672. Richest Customer Wealth
public static class RichestCustomerWealth
{
    public static int MaximumWealth(int[][] accounts)
    {
        int wealth = 0;
        for(int i = 0; i < accounts.Length; i ++)
        {
            int singleWealth = 0;
            for(int j = 0; j < accounts[i].Length; j++)
            {
                singleWealth += accounts[i][j];
            }
            if(singleWealth > wealth)
            {
                wealth = singleWealth;
            }
        }
        return wealth;
    }
}