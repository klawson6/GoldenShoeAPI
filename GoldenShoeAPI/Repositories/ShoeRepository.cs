﻿using GoldenShoeAPI.Context;
using GoldenShoeAPI.Domain;
using GoldenShoeAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GoldenShoeAPI.Repositories
{
	public class ShoeRepository: IShoeRepository
	{
		private readonly GoldenShoeContext _context;

		public ShoeRepository(GoldenShoeContext context)
		{
			_context = context;
		}

		public void Create(Shoe entity)
		{
			_context.Shoes.Add(entity);
			_context.SaveChanges();
		}

		public void Delete(Shoe entity)
		{
			_context.Shoes.Remove(entity);
			_context.SaveChanges();
		}

		public IEnumerable<Shoe> FindAll()
		{
			return _context.Shoes.AsEnumerable();
		}

		public IEnumerable<Shoe> FindByCondition(Func<Shoe, bool> expression)
		{
			return _context.Shoes.AsEnumerable().Where(s => expression(s));
		}

		public Shoe FindByID(int id)
		{
			return _context.Shoes.AsEnumerable().First(s => s.ShoeId == id);
		}

		public void Update(Shoe entity)
		{
			_context.Shoes.Update(entity);
			_context.SaveChanges();
		}
	}
}
