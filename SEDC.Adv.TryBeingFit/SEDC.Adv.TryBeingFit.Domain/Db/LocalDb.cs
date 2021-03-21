﻿using SEDC.Adv.TryBeingFit.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Db
{
	public class LocalDb<T> : IDb<T> where T : BaseEntity
	{
		public int IdCount { get; set; }
		private List<T> db;
		public LocalDb()
		{
			db = new List<T>();
			IdCount = 1;
		}

		public List<T> GetAll()
		{
			return db;
		}

		public T GetById(int id)
		{
			return db.FirstOrDefault(x => x.Id == id);
		}

		public int Insert(T entity)
		{
			entity.Id = IdCount;
			db.Add(entity);
			IdCount++;
			return entity.Id;
		}

		public void Remove(int id)
		{
			T item = db.FirstOrDefault(x => x.Id == id);
			if (item != null) db.Remove(item);
		}

		public void Update(T entity)
		{
			T item = db.FirstOrDefault(x => x.Id == entity.Id);
			item = entity;
		}
	}
}
