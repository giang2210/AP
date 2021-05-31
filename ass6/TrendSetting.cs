using System;
using System.Collections.Generic;

namespace T2008m.ass6
{
    public class TrendSetting : Clothing
    {
        
          public TrendSetting()
        {
            
        }
        
        //Set event display the name of regions
        public void MaximumSale()
        {
            Console.WriteLine("Maximum Sale");
        }
        public void AverageSale()
        {
            Console.WriteLine("Average Sale");
        }
        public void LowSale()
        {
            Console.WriteLine("Low Sale");
        }

        
        //Overide
        public override void Sales()
        {
            Console.WriteLine();
            float max = SaleArea1[0].Sale;
            float min = SaleArea1[0].Sale;
            List<int> ListChangeMax = new List<int>();
            List<int> ListChangeMin = new List<int>();
            List<string> AverageArea = new List<string>();
            List<string> MaxArea = new List<string>();
            List<string> MinArea = new List<string>();
            List<string> MaxAreaName = new List<string>();
            List<string> MinAreaName = new List<string>();
            int index = 0;
            foreach (var VARIABLE in SaleArea)
            {
                if (VARIABLE.Sale>=max)
                {
                    ListChangeMax.Add(index);
                    max = VARIABLE.Sale;
                    MaxArea.Add(VARIABLE.Name);
                    
                }else if (VARIABLE.Sale<=min)
                {
                    ListChangeMin.Add(index);
                    min = VARIABLE.Sale;
                    MinArea.Add(VARIABLE.Name);
                    
                }else if (VARIABLE.Sale<max && VARIABLE.Sale>min)
                {
                    AverageArea.Add(VARIABLE.Name);
                }
                index++;
                
            }
            
            //Truong hop doanh thu tang dan

            if (ListChangeMax.Count == SaleArea.Count)
            {
                
                MinAreaName.Add(MaxArea[0]);
                MaxAreaName.Add(MaxArea[MaxArea.Count-1]);
                for (int i = 1; i < (SaleArea.Count-1); i++)
                {
                    AverageArea.Add(SaleArea[i].Name);
                }
                //Truong hop doanh thu giam dan
            }else if (ListChangeMin.Count == SaleArea.Count)
            {
                MaxAreaName.Add(MinArea[0]);
                MinAreaName.Add(MinArea[MinArea.Count-1]);
                for (int i = 1; i < (SaleArea.Count-1); i++)
                {
                    AverageArea.Add(SaleArea[i].Name);
                }
                //Neu doanh thu random
            }else
            {
                MaxAreaName.Add(MaxArea[MaxArea.Count-1]);
                MinAreaName.Add(MinArea[MinArea.Count-1]);
                for (int i = 0; i < (ListChangeMax.Count - 1); i++)
                {
                    AverageArea.Add(SaleArea[ListChangeMax[i]].Name);
                }
                for (int i = 0; i < (ListChangeMin.Count - 1); i++)
                {
                    AverageArea.Add(SaleArea[ListChangeMin[i]].Name);
                }            }
            
            //In ra
            foreach (var VARIABLE in MaxAreaName)
            {
                Console.Write(VARIABLE+" : ");
                MaximumSale();
            }
            foreach (var VARIABLE in MinAreaName)
            {
                Console.Write(VARIABLE+" : ");
                LowSale();
            }
            foreach (var VARIABLE in AverageArea)
            {
                Console.Write(VARIABLE+" : ");
                AverageSale();
            }
        }
        //In ra tong doanh thu
        public void ShowSales(){
            float sum = 0;
            foreach (var VARIABLE in SaleArea)
            {
                sum += VARIABLE.Sale;
            }

            Console.WriteLine("Tong doanh thu la : "+sum);
        }
        public override void Materials(string a)
        {
        }

        public override void CommonWear()
        {
        }
    }
}