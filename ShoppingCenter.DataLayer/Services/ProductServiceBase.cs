﻿using ShoppingCenter.DataLayer.Models;
using ShoppingCenter.InfraStructure.Implementations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCenter.DataLayer.Services
{
	public abstract class ProductServiceBase: IProductService
	{
		public ProductServiceBase(IMongoRepository<Product> repository)
		{
			this.Repository = repository;
		}
		public IMongoRepository<Product> Repository { get; private set; }

		public virtual async Task<IEnumerable<Product>> GetAllAsync()
		{
			return await Repository.GetAllAsync();
		}

		public async Task<Product> GetByIdAsync(string id)
		{
			return await Repository.FindByIdAsync(id);
		}

	}
}