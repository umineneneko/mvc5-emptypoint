using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web.Models;

namespace web.DAL
{
    public class InitializeDB:System.Data.Entity.DropCreateDatabaseIfModelChanges<TVDbContext>
    {
        protected override void Seed(TVDbContext context)
        {
            var sr = new List<TVSeries> { 
            new TVSeries(){ID=1, Name="Car S.O.S", Description="Give it back to the road"},
            new TVSeries(){ID=2, Name="Ultimated Dubai", Description="Sky is home"},
            new TVSeries(){ID=3, Name="Secret Garden", Description="No matter how small of your garden"},
            new TVSeries(){ID=4, Name="Cosmo", Description="Space Odyse"},
            new TVSeries(){ID=5, Name="Sometimes", Description="Sometimes we have to see, to believe"},
            new TVSeries(){ID=6, Name="Street Genius", Description="Bring science to the street"},
            new TVSeries(){ID=7, Name="Naked Science", Description="Gravity law"},
            new TVSeries(){ID=8, Name="Food Detective", Description="Squize out the truth"},
            new TVSeries(){ID=9, Name="Food People", Description="Taste something new"},
            };
            sr.ForEach(s => context.TVSeries.Add(s));
            context.SaveChanges();


        }
    }
}