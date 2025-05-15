/*
<========== Learning Params ============>
1. It enables passing variable number of parameters to a function
*/
namespace CSharp13NewFeatures;
using System.Collections.Generic;

public class SalesData
{
    public List<int> Sales { get; set; }
}
public class FeedbackData
{
    public List<int> Feedback { get; set; }
}
public class InventoryData
{
    public Dictionary<int, string> Inventory { get; set; }
}

public class ReportGenerator{
    public void GenerateReport(params object[] datasets)
    {
        int totalSales = 0;
        int totalRatings = 0;
        float averageRatings = 0.0f;
        int numberOfFeedback = 0;
        int totalProductInStock = 0;

        if(datasets.Length == 0 || datasets == null)
        {
            Console.WriteLine("Invalid Dataset!");
            return;
        }

        foreach(var dataset in datasets)
        {
            if(dataset == null)
            {
                Console.WriteLine("Null Dataset Passed!"); 
                continue;
            }
            if(dataset is SalesData salesData)
            {
                foreach(var sales in salesData.Sales)
                {
                    totalSales += sales;
                }
                Console.WriteLine("Processed Sales Data.");
            }
            else if(dataset is FeedbackData feedbackData)
            {
                foreach (var feedback in feedbackData.Feedback)
                {
                    totalRatings += feedback;
                    numberOfFeedback++;
                }
                Console.WriteLine("Processed Feedback Data.");
            }
            else if(dataset is InventoryData inventoryData)
            {
                foreach(var inventory in inventoryData.Inventory)
                {
                    totalProductInStock += inventory.Key;
                }
                Console.WriteLine("Processed Inventory Data");
            }
            else
            {
                Console.WriteLine("Invalid Data Type Passed!");
            }
        }
        averageRatings = numberOfFeedback == 0? 0: (float)totalRatings/numberOfFeedback;

        Console.WriteLine("<============ Generated Sales Report ============>");
        Console.WriteLine($"Total Sales: {totalSales}");
        Console.WriteLine($"Total InStock product: {totalProductInStock}");
        Console.WriteLine($"Average Ratings: {averageRatings}");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n=========================");
        List<int> sales = new List<int> {10000,12000,11000,14000};
        SalesData salesData = new SalesData{Sales = sales};

        List<int> feedback = new List<int> {3,4,5,4,3};
        FeedbackData feedbackData = new FeedbackData{Feedback = feedback};

        Dictionary<int, string> inventory = new Dictionary<int,string> {
            {10, "Orange"},
            {20, "Apple"},
            {30, "Onion"},
            {40, "Mango"},
            {50, "Jackfruit"},
            };
        InventoryData inventoryData= new InventoryData{Inventory = inventory};

        ReportGenerator generator = new ReportGenerator();
        generator.GenerateReport(salesData, feedbackData, inventoryData);
        Console.WriteLine("=========================");
    }
}