using Mango.Web.Models;
using Mango.Web.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mango.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> CreateProductAsync<T>(ProductDto productDto)
        {
            return await this.SendAsyc<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = productDto,
                Url = string.Concat(SD.ProductAPIBase, "/api/products/"),
                AccessToken = string.Empty
            });
        }

        public async Task<T> DeleteProductAsync<T>(int id)
        {
            return await this.SendAsyc<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = string.Concat(SD.ProductAPIBase, "/api/products/", id),
                AccessToken = string.Empty
            });
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await this.SendAsyc<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = string.Concat(SD.ProductAPIBase, "/api/products/"),
                AccessToken = string.Empty
            });
        }

        public async Task<T> GetProductByIdAsync<T>(int id)
        {
            return await this.SendAsyc<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = string.Concat(SD.ProductAPIBase, "/api/products/", id),
                AccessToken = string.Empty
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
        {
            return await this.SendAsyc<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = productDto,
                Url = string.Concat(SD.ProductAPIBase, "/api/products/"),
                AccessToken = string.Empty
            });
        }
    }
}
