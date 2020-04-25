﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhoPLII
{
    public class Infecao
    {

        #region Estado

        //Tipo de infeção ou doença apresentada
        string tipo;
        // Nome
        string nome;

        // Exemplo: tipo - virus , nome - Varicela


        #endregion

        #region Properties

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

        #region Construtor

        public Infecao(string t, string n)
        {
            nome = n;
            tipo = t;
        }

        #endregion

    }
