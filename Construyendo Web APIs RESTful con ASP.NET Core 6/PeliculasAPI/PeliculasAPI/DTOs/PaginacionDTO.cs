﻿namespace PeliculasAPI.DTOs
{
    public class PaginacionDTO
    {

        public int Pagina { get; set; } = 1;
        public int cantidadRegistrosPorPagina = 10;
        private readonly int cantidadMaximaRegistrosPorPagina = 50;

        public int CantidadRegistrosPorPagina
        {
            get => cantidadRegistrosPorPagina;
            set
            {
                cantidadRegistrosPorPagina = (value > cantidadMaximaRegistrosPorPagina) 
                    ? cantidadMaximaRegistrosPorPagina : value;
            }
        }
    }
}
