﻿using AluguelCarro.DAO;
using AluguelCarro.src.Entity;
using AluguelCarro.src.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelCarro.src.Service
{
    internal class FuncionarioService : IFuncionarioService, ICrudService<Funcionario>
    {
        private IFuncionarioDAO _funcionarioDAO;
        private IGenericDAO<Funcionario> _gerericDAO;

        public FuncionarioService(IFuncionarioDAO funcionarioDAO, IGenericDAO<Funcionario> gerericDAO)
        {
            _funcionarioDAO = funcionarioDAO;
            _gerericDAO = gerericDAO;
        }

        public bool Adicionar(Funcionario funcionario)
        {
            try
            {
                //FuncionarioValidator.Validar(funcionario);
                return _gerericDAO.Adicionar(funcionario);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }
        
        public Funcionario BuscarUnico(Funcionario funcionario)
        {
            try
            {
                return _gerericDAO.BuscarUnico(funcionario);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool Atualizar(Funcionario funcionario)
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                return _gerericDAO.Atualizar(funcionario);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public List<Funcionario> BuscarVarios()
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                return _gerericDAO.BuscarVarios();
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

        public bool Remover(Funcionario funcionario)
        {
            try
            {
                //ClienteValidator.Validar(cliente);
                return _gerericDAO.Remover(funcionario);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                throw;
            }
        }

    }
}