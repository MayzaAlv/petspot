﻿using Petspot.Areas.Identity.Data;
using Petspot.Models;

namespace Petspot.Services.Handlers
{
    public class HomeService : IHomeService
    {
        private readonly ApplicationDbContext _context;
        public HomeService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Search the owners
        /// </summary>
        /// <param name="Owner"></param>
        /// <returns></returns>
        public List<Owner> Search(string Owner)
        {
            List<Owner> owners = _context.Owners.ToList();

            if (!string.IsNullOrEmpty(Owner))
            {
                owners = owners.Where(s => s.Name!
                .Contains(Owner, StringComparison.OrdinalIgnoreCase)).ToList();

            }
            return owners;
        }
    }
}
