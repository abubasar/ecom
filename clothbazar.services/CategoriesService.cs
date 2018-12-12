﻿using clothbazar.database;
using clothbazar.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clothbazar.services
{
    public class CategoriesService
    {
        public void SaveCategory(Category category)
        {
            using(var context=new CBContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
                
            }

        }

        public List<Category> GetCategories()
        {
            using (var context = new CBContext())
            {
                return context.Categories.ToList();
            }

        }

        public Category GetCategory(int ID)
        {
            using (var context = new CBContext())
            {
                return context.Categories.Find(ID);
            }

        }

        public void UpdateCategory(Category category)
        {
            using (var context = new CBContext())
            {
                context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }

        }

        public void DeleteCategory(int ID)
        {
            using (var context = new CBContext())
            {
                //context.Entry(category).State = System.Data.Entity.EntityState.Modified;
                var category = context.Categories.Find(ID);
                context.Categories.Remove(category);
                context.SaveChanges();
            }

        }
    }
}
