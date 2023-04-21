using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;

namespace AsNoTracking;

[ShortRunJob, Config(typeof(Config))]
public class BencmarkService
{
    private class Config : ManualConfig
    {
        public Config()
        {
            SummaryStyle = BenchmarkDotNet.Reports.SummaryStyle.Default.WithRatioStyle(BenchmarkDotNet.Columns.RatioStyle.Trend);
        }
    }

    //[Benchmark(Baseline = true)]
    //public void GetAllWithTracking()
    //{
    //    AppDbContext context = new();

    //    context.Products.ToList();
    //}

    //[Benchmark]
    //public void GetAllWithAsNoTracking()
    //{
    //    AppDbContext context = new();

    //    context.Products.AsNoTracking().ToList();
    //}

    //[Benchmark(Baseline = true)]
    //public void GetFirstWithTracking()
    //{
    //    AppDbContext context = new();

    //    context.Products.First();
    //}

    //[Benchmark]
    //public void GetFirstWithAsNoTracking()
    //{
    //    AppDbContext context = new();

    //    context.Products.AsNoTracking().First();
    //}

    public void Find()
    {
        AppDbContext context = new();

        context.Products.FromSqlRaw("Select * From").AsNoTracking().ToList();
    }
}
