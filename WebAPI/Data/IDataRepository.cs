﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Data
{
    /// <summary>
    /// Defines basic data operations executed on Database Context.
    /// </summary>
    public interface IDataRepository
    {
        /// <summary>
        /// Gets all files asynchronous.
        /// </summary>
        /// <returns>All files.</returns>
        public Task<IEnumerable<DataFile>> GetAllFilesAsync();

        /// <summary>
        /// Gets the file by name asynchronous.
        /// </summary>
        /// <returns>The found file.</returns>
        public Task<DataFile> GetFileByNameAsync();

        /// <summary>
        /// Gets the file by identifier.
        /// </summary>
        /// /// <param name="id">The id.</param>
        /// <returns></returns>
        public DataFile GetFileById(int id);

        /// <summary>
        /// Adds the file asynchronous.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns>True if file was added, if file exists already, then false.</returns>
        public Task<DataFile> AddFileAsync(DataFile file);

        /// <summary>
        /// Deletes the file asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>True if successfully deleted, false if not found.</returns>
        public Task<bool> DeleteFileAsync(int id);

        /// <summary>
        /// Saves the changes asynchronous.
        /// </summary>
        /// <returns></returns>
        public Task SaveChangesAsync();
    }
}
