using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishCenterData.Models
{
    public class HETHONGCHAMSOCHOCVIENContextFactory : IDesignTimeDbContextFactory<HETHONGCHAMSOCHOCVIENContext>
    {
        public HETHONGCHAMSOCHOCVIENContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<HETHONGCHAMSOCHOCVIENContext>();
            optionsBuilder.UseSqlServer("Server=(local)\\sqlexpress;Database=HETHONGCHAMSOCHOCVIEN;Trusted_Connection=True;");
            return new HETHONGCHAMSOCHOCVIENContext(optionsBuilder.Options);
        }
    }
}
