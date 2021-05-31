namespace T2008m.ass6
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            TrendSetting trendSetting = new TrendSetting();
            Areas area1 = new Areas();
            area1.Name = "area1";
            area1.Sale = 40;
            Areas area2 = new Areas();
            area2.Name = "area2";
            area2.Sale = 20;
            Areas area3 = new Areas();
            area3.Name = "area3";
            area3.Sale = 70;
            Areas area4 = new Areas();
            area4.Name = "area4";
            area4.Sale = 60;
            Areas area5 = new Areas();
            area5.Name = "area5";
            area5.Sale = 80;
            trendSetting.SaleArea.Add(area1);
            trendSetting.SaleArea.Add(area2);
            trendSetting.SaleArea.Add(area3);
            trendSetting.SaleArea.Add(area4);
            trendSetting.SaleArea.Add(area5);
            trendSetting.Sales();
            trendSetting.ShowSales();
        }
    }
}