using System;
using VueWithDotNet.Application.Interfaces;

namespace VueWithDotNet.Infrastructure.Shared
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}
