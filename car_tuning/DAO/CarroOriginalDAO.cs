﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_tuning.DAO
{
    class CarroOriginalDAO
    {
        public void Salvar(Modelo.CarroOriginal carro)
        {
            DataBase db = DataBase.GetInstance();
            db.GetConnection();



        }

        public void Deletar(int id)
        {

        }
        public void Atualizar(Cliente cliente)
        {

        }
        public List<Cliente> listAll()
        {
            List<Cliente> lista = new List<Cliente>();
            Cliente cliente = null;


            return lista;

        }
        public List<Cliente> BuscaNome(string cpf)
        {
            List<Cliente> lista = new List<Cliente>();
            Cliente cliente = null;


            return lista;
        }
    }
}
