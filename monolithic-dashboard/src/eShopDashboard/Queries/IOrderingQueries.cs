﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopDashboard.Queries
{
    public interface IOrderingQueries
    {
        Task<IEnumerable<dynamic>> GetCountryHistoryAsync(string country);

        Task<IEnumerable<dynamic>> GetProductHistoryAsync(string productId);

        Task<IEnumerable<dynamic>> GetProductStatsAsync(string productId);
    }
}