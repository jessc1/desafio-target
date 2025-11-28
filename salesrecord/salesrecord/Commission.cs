using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

public class Commission
{
    public static void CalculateCommissions(string filePath)
    {
        string jsonString = File.ReadAllText(filePath);
        Vendas salesRecord = JsonSerializer.Deserialize<Vendas>(jsonString)!;
        if (salesRecord != null && salesRecord.vendas != null)
        {
            double total = 0;
            foreach (var record in salesRecord.vendas)
            {
                if (record.valor <= 100)
                {
                    
                    total = record.valor;
                }
                if(record.valor <= 500)
                {                    
                    total = record.valor + record.valor * 0.01;
                }
                if(record.valor > 500)
                {
                    
                    total = record.valor + record.valor * 0.05;
                    
                }
            Console.WriteLine($"Vendedor: {record.vendedor}");
            Console.WriteLine($"Valor com Commissão: ${total:F2}");
            Console.WriteLine(new string('-', 30));
                          
            }
       
        }

        
    }
}
