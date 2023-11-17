﻿using AutoYa_Backend.Security.Domain.Models;
using AutoYa_Backend.Security.Domain.Repositories;
using AutoYa_Backend.Shared.Persistence.Contexts;
using AutoYa_Backend.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AutoYa_Backend.Security.Persistence.Repositories;

public class UserRepository : BaseRepository, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }
    public async Task<IEnumerable<User>> ListAsync()
    {
        return await _context.Users.ToListAsync();
    }
    public async Task AddAsync(User user)
    {
        await _context.Users.AddAsync(user);
    }
    public async Task<User> FindByIdAsync(int id)
    {
        return await _context.Users.FindAsync(id);
    }
    public async Task<User> FindByEmailAsync(string email)
    {
        return await _context.Users.SingleOrDefaultAsync(x => 
            x.Email == email);
    }
    public bool ExistsByEmail(string email)
    {
        return _context.Users.Any(x => x.Email == email);
    }
    public User FindById(int id)
    {
        return _context.Users.Find(id);
    }
    public void Update(User user)
    {
        _context.Users.Update(user);
    }
    public void Remove(User user)
    {
        _context.Users.Remove(user);
    }
}