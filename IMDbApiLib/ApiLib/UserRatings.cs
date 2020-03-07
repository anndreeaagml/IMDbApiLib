﻿using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<UserRatingData> UserRatingAsync(string id)
        {
            try
            {
                string url = $"{BaseUrl}/en/API/UserRating/{_apiKey}/{id}";
                return await Utils.DownloadObjectAsync<UserRatingData>(url);
            }
            catch (Exception ex)
            {
                return new UserRatingData() { ErrorMessage = ex.Message };
            }
        }
    }
}
