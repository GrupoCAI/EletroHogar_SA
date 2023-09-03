﻿using Modelo;
using Negocio;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRESENTACION
{
    public class AltaUsuario
    {
        
        public UsuarioModel DarAltaUsuario()
        {
            bool flag = false;
            string inputNombre;
            string inputApellido;
            string inputDireccion;
            string inputTelefono;
            string inputEmail;
            string inputFechaNacimiento;
            DateTime fechaNacimiento = DateTime.Now;
            string inputPerfil;
            int perfil = 0;
            string inputDni;
            int dni = 0;
            string NombreUsuario;
            string inputContra;
            int minCaracteresUsuario = 8;
            int maxCaracteresUsuario = 15;

            do
            {
                Console.Write("Ingresar el nombre: ");
                inputNombre = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputNombre, "Nombre");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar el apellido: ");
                inputApellido = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputApellido, "Apellido");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar la dirección: ");
                inputDireccion = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputDireccion, "Dirección");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar un teléfono: ");
                inputTelefono = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputTelefono, "Telefono");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar un mail: ");
                inputEmail = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(inputEmail, "Email");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar tu fecha de nacimiento: ");
                inputFechaNacimiento = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarFecha(inputFechaNacimiento, ref fechaNacimiento, "Fecha de Nacimiento");
            } while (flag == false);

            do
            {
                Console.WriteLine("El Nombre de Usuario debe tener entre 8 a 15 caracteres y no debe tener su nombre o apellido dentro del mismo.");
                Console.Write("Ingresar Nombre de Usuario: ");
                NombreUsuario = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarVacio(NombreUsuario, "Nombre");

                ValidacionesUsuario validadorUsuario = new ValidacionesUsuario();
                flag = validadorUsuario.ValidarNombreUsuario(NombreUsuario, inputNombre, inputApellido, minCaracteresUsuario, maxCaracteresUsuario);

            } while (flag == false);

            do
            {
                Console.WriteLine("1- Perfil Administrador");
                Console.WriteLine("2- Perfil Supervisor");
                Console.WriteLine("3- Perfil Vendedor");
                Console.Write("Seleccionar la opcion correspondiente del Perfil: ");
                inputPerfil = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarNumero(inputPerfil, ref perfil, "Perfil");
                flag = validador.ValidarTipoNum(ref perfil, "Perfil");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar su DNI: ");
                inputDni = Console.ReadLine();
                ValidacionesDatos validador = new ValidacionesDatos();
                flag = validador.ValidarNumero(inputDni, ref dni, "DNI");
            } while (flag == false);

            do
            {
                Console.Write("Ingresar su Contraseña: ");
                inputContra = Console.ReadLine();

                //AGREGAR VALIDACIONES DE CONTRASEÑA

            } while (flag == false);
            MetodosUsuarios usu = new MetodosUsuarios();
            return usu.CrearUsuario(inputNombre, inputApellido, inputDireccion, inputTelefono, inputEmail, fechaNacimiento, NombreUsuario, perfil, dni, inputContra);
        }
    }
}