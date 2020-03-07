﻿using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace IMDbApiLib
{
    public partial class ApiLib
    {
        public async Task<Top250Data> Top250MoviesAsync()
        {
            try
            {
                string url = $"{BaseUrl}/en/API/Top250Movies/{_apiKey}";
                return await Utils.DownloadObjectAsync<Top250Data>(url);
            }
            catch (Exception ex)
            {
                return new Top250Data() { ErrorMessage = ex.Message };
            }
        }
    }
}
