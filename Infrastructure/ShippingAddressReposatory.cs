﻿using Application.Contracts;
using Context;
using Domain;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class ShippingAddressReposatory : Reposatory<shippingAddress, int>,IShippingAddressRepository
    {
        private readonly ApplicationContext context;
        private readonly DbSet<shippingAddress> dbset;
        public ShippingAddressReposatory(ApplicationContext context) : base(context)
        {
            this.context = context;
            dbset = this.context.Set<shippingAddress>();

        }

       

        public async Task<shippingAddress> GetAddressForUserById(string userid)
        {
            return await dbset.Include(c=>c.City).FirstOrDefaultAsync(u => u.userid == userid);
             
        }
    }
}
