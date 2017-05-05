using System;
using System.IO;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Microsoft.Extensions.Configuration;

namespace aws_table_prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var options = config.GetAWSOptions();
            var client = options.CreateServiceClient<IAmazonDynamoDB>();
            var contextConfig = new DynamoDBContextConfig();

            Console.WriteLine($"prefix:{contextConfig.TableNamePrefix}");
        }
    }
}
