﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class SQLDataRepository : IDataRepository
    {
        private readonly DataFileContext _context;

        public SQLDataRepository(DataFileContext context)
        {
            _context = context;
        }

        public async Task<DataFile> AddFileAsync(DataFile file)
        {
            var obj = await _context.DataFiles.AddAsync(file);
            return obj.Entity;
        }

        public async Task<bool> DeleteFileAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<DataFile>> GetAllFilesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<DataFile> GetFileByNameAsync()
        {
            throw new NotImplementedException();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
