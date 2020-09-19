using Microsoft.AspNetCore.Mvc;
using System;
using WebApi.Models;

namespace WebApi.Infrastructure
{
    public class WebApiControllerBase : ControllerBase
    {
        private void LogError(Exception ex)
        {
            try
            {
                ErrorLog _error = new ErrorLog()
                {
                    Message = ex.Message,
                    StackTrace = ex.StackTrace,
                    CreatedOn = DateTime.Now
                };

                //_errorsRepository.Add(_error);
                //_unitOfWork.Commit();
            }
            catch { }
        }
    }
}
