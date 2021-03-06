﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using DatosVentas;
using CapaDatos;

namespace CapaUsuario.Ventas
{
    public class ExecuteQuery
    {

        public static void InsertInto(int option, object[] parameters)
        {
            InsertsCommands.insertInto(option, parameters);
            if (CapaDatos.MessageException.message != "")
            {
                MessageBox.Show("Error al ejecutar la insercion: " + CapaDatos.MessageException.message,
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void DeleteFrom(int option, int code)
        {
            Delete.deleteFrom(option, code);
            if (CapaDatos.MessageException.message != "")
            {
                MessageBox.Show("Error al borrar: " + CapaDatos.MessageException.message,
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable SelectAll(int option)
        {
            DataTable tab = SelectCommands.selectAll(option);
            if (CapaDatos.MessageException.message != "")
            {
                MessageBox.Show("Error al ejecutar la consulta: " + CapaDatos.MessageException.message,
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
                return tab;
        }
        public static DataTable SelectOne(int option, object parameter)
        {
            DataTable tab = SelectCommands.selectOne(option, parameter);
            if (CapaDatos.MessageException.message != "")
            {
                MessageBox.Show("Error al ejecutar la consulta: " + CapaDatos.MessageException.message,
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else
                return tab;
        }
        public static bool? SelectExist(int option, int cod)
        {
            bool result = SelectCommands.selectExist(option, cod);
            if (CapaDatos.MessageException.message != "")
            {
                MessageBox.Show("Error al ejecutar la consulta: " + CapaDatos.MessageException.message,
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            else

                return result;
        }
        public static bool? SelectCheckState(int option, int cod)
        {
            bool result = SelectCommands.selectCheckState(option, cod);
            if (CapaDatos.MessageException.message != "")
            {
                MessageBox.Show("Error al ejecutar la consulta: " + CapaDatos.MessageException.message,
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return result;
        }
        public static string SelectReturnString(int option, int cod)
        {
            string result = SelectCommands.selectReturnString(option, cod);
            if (CapaDatos.MessageException.message != "")
            {
                MessageBox.Show("Error al ejecutar la consulta: " + CapaDatos.MessageException.message,
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return result;
        }
        public static int? SelectCode(int option, object field)
        {
            int result = SelectCommands.selecCode(option, field);
            if (CapaDatos.MessageException.message != "")
            {
                MessageBox.Show("Error al ejecutar la consulta: " + CapaDatos.MessageException.message,
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return result;
        }
        public static void UpdateMany(int option, Object[] parameters)
        {
            UpdateCommands.updateMany(option, parameters);
            if (CapaDatos.MessageException.message != "")
            {
                MessageBox.Show("Error al ejecutar la modificacion: " + CapaDatos.MessageException.message,
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void UpdateOne(int option, int cod, object parameter)
        {
            UpdateCommands.updateOne(option, cod, parameter);
            if (CapaDatos.MessageException.message != "")
            {
                MessageBox.Show("Error al ejecutar la modificacion: " + CapaDatos.MessageException.message,
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
