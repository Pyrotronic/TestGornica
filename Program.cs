
using System.Text.RegularExpressions;

internal class Program
{
    public static void InformationOfSp(string str)
    {
       
        float total_thicknessSP = 0f;
        int Chamberlaincy = 1;
        float total_thicknessG = 0f;
        string[] SP = str.Split('/');
        for (int i = 0; i < SP.Length; i++)
        {
            
            total_thicknessSP += float.Parse(Regex.Match(SP[i], @"\d+").Value);
            if (i % 2 != 1) 
            {
                total_thicknessG += float.Parse(Regex.Match(SP[i], @"\d+").Value);
            }
        }
        if (SP.Length == 5)
            Chamberlaincy = 2;
        Console.WriteLine($"Камерность: {Chamberlaincy}, Толщина стекла: {total_thicknessG}, Толщина СП: {total_thicknessSP}");
    }
    private static void Main(string[] args)
    {
        string[] str = { "6 SG HD Silver Grey 32 ЗАК/16/6 м1/16/6 ЗАК", "4/16/4", "4 TOP-N/14/6_м1", "4 ПлА2/16/4м1", "4 TOP-N/14ar/4 м1/14ar/4_StClBr", "10 м1/22/8 м1" };
        for(int i = 0; i < str.Length; i++)
        {
            InformationOfSp(str[i]);
        }
        
    }
}