﻿using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<SearchData> SearchNameAsync(string expression)
        {
            try
            {
                expression = PrepareExpression(expression);
                string url = $"{BaseUrl}/en/API/SearchName/{_apiKey}/{expression}";
                return await Utils.DownloadObjectAsync<SearchData>(url, WebProxy);
            }
            catch (Exception ex)
            {
                return new SearchData() { ErrorMessage = ex.Message };
            }
        }
    }
}
