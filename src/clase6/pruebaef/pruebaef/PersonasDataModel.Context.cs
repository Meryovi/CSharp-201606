﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pruebaef
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class cursocsharpEntities : DbContext
    {
        public cursocsharpEntities()
            : base("name=cursocsharpEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Persona> Personas { get; set; }
    
        public virtual ObjectResult<PersonasBuscarTodas_Result> PersonasBuscarTodas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PersonasBuscarTodas_Result>("PersonasBuscarTodas");
        }
    
        public virtual int PersonasCrear(string identificacion, string nombre, string sexo, Nullable<System.DateTime> fechaNacimiento, Nullable<bool> esEmpleado, Nullable<decimal> sueldo)
        {
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var fechaNacimientoParameter = fechaNacimiento.HasValue ?
                new ObjectParameter("FechaNacimiento", fechaNacimiento) :
                new ObjectParameter("FechaNacimiento", typeof(System.DateTime));
    
            var esEmpleadoParameter = esEmpleado.HasValue ?
                new ObjectParameter("EsEmpleado", esEmpleado) :
                new ObjectParameter("EsEmpleado", typeof(bool));
    
            var sueldoParameter = sueldo.HasValue ?
                new ObjectParameter("Sueldo", sueldo) :
                new ObjectParameter("Sueldo", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PersonasCrear", identificacionParameter, nombreParameter, sexoParameter, fechaNacimientoParameter, esEmpleadoParameter, sueldoParameter);
        }
    }
}