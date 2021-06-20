﻿using SistemasContables.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasContables.DataBase
{
    public class CuentasDAO : DAO
    {
        private List<Cuenta> lista;

        public CuentasDAO()
        {
            lista = new List<Cuenta>();
        }

        public bool agregarCuenta(Cuenta cuenta)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"INSERT INTO {TABLE_CUENTA} ({ID_CUENTA}, {CODIGO}, {NIVEL}, {NOMBRE_CUENTA}, {TIPO_SALDO}) ";
                    sql += $"VALUES(NULL, @{CODIGO}, @{NIVEL}, @{NOMBRE_CUENTA}, @{TIPO_SALDO});";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{CODIGO}", cuenta.Codigo);
                    command.Parameters.AddWithValue($"@{NIVEL}", cuenta.Nivel);
                    command.Parameters.AddWithValue($"@{NOMBRE_CUENTA}", cuenta.Nombre);
                    command.Parameters.AddWithValue($"@{TIPO_SALDO}", cuenta.TipoSaldo);
                    command.ExecuteNonQuery();

                    conn.Close();

                    return true;
                }

            }
            catch(Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public bool agregarListaDeCuentas(List<Cuenta> listCuentas)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                foreach(Cuenta cuenta in listCuentas)
                {
                    using (SQLiteCommand command = new SQLiteCommand())
                    {
                        string sql = $"INSERT INTO {TABLE_CUENTA} ({ID_CUENTA}, {CODIGO}, {NIVEL}, {NOMBRE_CUENTA}, {TIPO_SALDO}) ";
                        sql += $"VALUES(NULL, @{CODIGO}, @{NIVEL}, @{NOMBRE_CUENTA}, @{TIPO_SALDO});";

                        command.CommandText = sql;
                        command.Connection = Conexion.Conn;
                        command.Parameters.AddWithValue($"@{CODIGO}", cuenta.Codigo);
                        command.Parameters.AddWithValue($"@{NIVEL}", cuenta.Nivel);
                        command.Parameters.AddWithValue($"@{NOMBRE_CUENTA}", cuenta.Nombre);
                        command.Parameters.AddWithValue($"@{TIPO_SALDO}", cuenta.TipoSaldo);
                        command.ExecuteNonQuery();
                    }
                }

                conn.Close();

                return true;

            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Cuenta> getList()
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_CUENTA}";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {

                            if (lista.Count > 0)
                            {
                                lista.Clear();
                            }

                            while (result.Read())
                            {
                                Cuenta cuenta = new Cuenta();

                                cuenta.IdCuenta = Convert.ToInt32(result[ID_CUENTA]);
                                cuenta.Codigo = result[CODIGO].ToString();
                                cuenta.Nivel = Convert.ToInt32(result[NIVEL]);
                                cuenta.Nombre = result[NOMBRE_CUENTA].ToString();
                                cuenta.TipoSaldo = result[TIPO_SALDO].ToString();

                                lista.Add(cuenta);
                            }
                        }
                    }

                }
                conn.Close();

            } catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }

        public List<Cuenta> listaNivelTipo(int nivel, string tipo)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_CUENTA} WHERE ({NIVEL} = @{NIVEL}) AND ({TIPO_SALDO} = @{TIPO_SALDO})";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{NIVEL}", nivel);
                    command.Parameters.AddWithValue($"@{TIPO_SALDO}", tipo);

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {

                            if (lista.Count > 0)
                            {
                                lista.Clear();
                            }

                            while (result.Read())
                            {
                                Cuenta cuenta = new Cuenta();

                                cuenta.IdCuenta = Convert.ToInt32(result[ID_CUENTA]);
                                cuenta.Codigo = result[CODIGO].ToString();
                                cuenta.Nivel = Convert.ToInt32(result[NIVEL]);
                                cuenta.Nombre = result[NOMBRE_CUENTA].ToString();
                                cuenta.TipoSaldo = result[TIPO_SALDO].ToString();

                                lista.Add(cuenta);
                            }
                        }
                    }

                }
                conn.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }

        public List<Cuenta> listaNivel(int nivel)
        {
            try
            {
                conn = Conexion.Conn;

                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"SELECT * FROM {TABLE_CUENTA} WHERE ({NIVEL} = @{NIVEL})";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{NIVEL}", nivel);

                    using (SQLiteDataReader result = command.ExecuteReader())
                    {
                        if (result.HasRows)
                        {

                            if (lista.Count > 0)
                            {
                                lista.Clear();
                            }

                            while (result.Read())
                            {
                                Cuenta cuenta = new Cuenta();

                                cuenta.IdCuenta = Convert.ToInt32(result[ID_CUENTA]);
                                cuenta.Codigo = result[CODIGO].ToString();
                                cuenta.Nivel = Convert.ToInt32(result[NIVEL]);
                                cuenta.Nombre = result[NOMBRE_CUENTA].ToString();
                                cuenta.TipoSaldo = result[TIPO_SALDO].ToString();

                                lista.Add(cuenta);
                            }
                        }
                    }

                }
                conn.Close();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return lista;
        }

        public bool update(Cuenta cuenta)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"UPDATE {TABLE_CUENTA} SET {CODIGO}=@{CODIGO}, {NIVEL}=@{NIVEL}, {NOMBRE_CUENTA}=@{NOMBRE_CUENTA}, {TIPO_SALDO}=@{TIPO_SALDO} ";
                    sql += $"WHERE {ID_CUENTA} = @{ID_CUENTA};";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{ID_CUENTA}", cuenta.IdCuenta);
                    command.Parameters.AddWithValue($"@{CODIGO}", cuenta.Codigo);
                    command.Parameters.AddWithValue($"@{NIVEL}", cuenta.Nivel);
                    command.Parameters.AddWithValue($"@{NOMBRE_CUENTA}", cuenta.Nombre);
                    command.Parameters.AddWithValue($"@{TIPO_SALDO}", cuenta.TipoSaldo);
                    command.ExecuteNonQuery();

                    conn.Close();

                    return true;
                }

            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        public bool delete(int idCuenta)
        {
            try
            {
                conn = Conexion.Conn;
                conn.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    string sql = $"DELETE FROM {TABLE_CUENTA_PARTIDA} WHERE {ID_CUENTA} = @{ID_CUENTA}; ";
                    sql += $"DELETE FROM {TABLE_CUENTA} WHERE {ID_CUENTA} = @{ID_CUENTA}; ";

                    command.CommandText = sql;
                    command.Connection = Conexion.Conn;
                    command.Parameters.AddWithValue($"@{ID_CUENTA}", idCuenta);
                    command.ExecuteNonQuery();

                    conn.Close();

                    return true;
                }

            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

    }
}
