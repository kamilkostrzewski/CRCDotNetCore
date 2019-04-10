using DotNetCoreWebApi.DbContexts;
using DotNetCoreWebApi.Model;
using DotNetCoreWebAPI.Repository;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreWebAPI.UnitTests
{
    public static class MeasurementContextMocker
    {
        public static IMeasurementRepository<Measurement> GetInMemoryMeasurementsRepository(string dbName)
        {
            var options = new DbContextOptionsBuilder<MeasurementContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            MeasurementContext measurementContext = new MeasurementContext(options);
            measurementContext.FillDatabase();

            return new MeasurementRepository(measurementContext);
        }
    }
}