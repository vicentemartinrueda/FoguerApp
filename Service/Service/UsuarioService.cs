﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Database.General.Context;
using Database.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly FoguerAppDbContext _context;
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;
        public UsuarioService(FoguerAppDbContext context, IUsuarioRepository usuarioRepository, IMapper mapper) 
        {
            _context = context;
            _repository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
            _mapper = mapper;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<List<DtoUsuario>> Get() 
        {
            List<DtoUsuario> usuarios = await _repository.Get()
                .ProjectTo<DtoUsuario>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return usuarios;
        }
    }
}
