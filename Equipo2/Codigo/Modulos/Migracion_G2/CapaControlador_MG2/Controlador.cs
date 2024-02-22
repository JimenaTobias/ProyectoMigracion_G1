﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_MG2;
using System.Data.Odbc;
using System.Data;
using CapaModelo_MG2.Sentences;
using CapaModelo_MG2.Templates;

namespace CapaControlador_MG2
{

    public class Controlador
    {
        Sentencias sn = new Sentencias();
        public CitaSentence sn_cita = new CitaSentence();
        public BoletaSentence sn_boleta = new BoletaSentence();
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void updateCita(int correlativo, DateTime nuevaFecha)
        {
            Console.WriteLine("Controlador");
            this.sn_cita.update(new Cita(correlativo, nuevaFecha));
        }

        public bool existBol(int bolId, int bolCorr)
        {
            return this.sn_boleta.findBol(bolId, bolCorr);
        }

        public void saveBol()
        {
            this.sn_boleta.saveBoleta();
        }

        public bool dateIsAvailable(string _date)
        {
            return this.sn_cita.getDatesByDateTime(_date) < 1;
        }

        public void saveCita(Persona persona)
        {
            this.sn_cita.saveCita(persona);
        }

    }
}
