/*----------------------------------------------------------------
* 项目名称 ：Ocelot.Infrastructure.RequestData
* 项目描述 ：
* 类 名 称 ：HttpDataRepository
* 类 描 述 ：
* 所在的域 ：PC-20210617KGT4
* 命名空间 ：Ocelot.Infrastructure.RequestData
* 机器名称 ：PC-20210617KGT4
* CLR 版本 ：4.0.30319.42000
* 作 者 ：蔡显麒
* 创建时间 ：2022/3/1 10:38:14
* 更新时间 ：2022/3/1 10:38:14
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Administrator 2022. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/

using Microsoft.AspNetCore.Http;
using Ocelot.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ocelot.Infrastructure.RequestData
{
    public class HttpDataRepository : IRequestScopedDataRepository
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HttpDataRepository(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Response Add<T>(string key, T value)
        {
            try
            {
                _httpContextAccessor.HttpContext.Items.Add(key, value);
                return new OkResponse();
            }
            catch(Exception ex)
            {
                return new ErrorResponse(new CannotAddDataError(string.Format($"Unable to add data for key: {key}, exception: {ex.Message}")));
            }
            
        }

            public Response<T> Get<T>(string key)
            {
            object obj;

            if (_httpContextAccessor.HttpContext == null || _httpContextAccessor.HttpContext.Items == null)
            {
                return new ErrorResponse<T>(new CannotFindDataError($"Unable to find data for key: {key} because HttpContext or HttpContext.Items is null"));
            }

            if (_httpContextAccessor.HttpContext.Items.TryGetValue(key, out obj))
            {
                var data = (T)obj;
                return new OkResponse<T>(data);
            }

            return new ErrorResponse<T>(new CannotFindDataError($"Unable to find data for key: {key}"));
        }

            public Response Update<T>(string key, T value)
            {
            try
            {
                _httpContextAccessor.HttpContext.Items[key] = value;
                return new OkResponse();
            }
            catch (Exception exception)
            {
                return new ErrorResponse(new CannotAddDataError(string.Format($"Unable to update data for key: {key}, exception: {exception.Message}")));
            }
        }
        }
    }
