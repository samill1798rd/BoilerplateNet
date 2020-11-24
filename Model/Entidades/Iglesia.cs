using System;

namespace Model.Entidades
{

    public class Iglesia : AEntity<int>
    {

        public string Sexo_DP { get; set; }
        public string Apellidos_DP { get; set; }
        public string Nombres_DP { get; set; }
        public DateTime? FechaNacimiento_DP { get; set; }
        public DateTime? PaisNacimiento_DP { get; set; }
        public string CiudadNacimiento_DP { get; set; }
        public string PaisResidenciaActual_DP { get; set; }
        public string CiudadResidneciaActual_DP { get; set; }
        public string Direccion_DP { get; set; }
        public string Telefono_DP { get; set; }
        public string Celular_DP { get; set; }
        public string Correo_DP { get; set; }
        public string TipoIdentidad_DP { get; set; }
        public string DocumentoIdentidad_DP { get; set; }
        public string EstadoCivil_DF { get; set; }
        public string NombrePareja_DF { get; set; }
        public string Hijos_DF { get; set; }
        public string NoHijos_DF { get; set; }
        public string Profesion_DL { get; set; }
        public string OcupacionActual_DL { get; set; }
        public string NombreEmpresa_DL { get; set; }
        public string EmpresaTelefono_DL { get; set; }
        public DateTime? FechaConvencion_DE { get; set; }
        public DateTime? FechaBautismo_DE { get; set; }
        public DateTime? FechaAceptado_DE { get; set; }
        public string Denominacion_DE { get; set; }
        public string NombreIglesiaActual_DE { get; set; }
        public string IglesiaMenorTiempo_DE { get; set; }
        public string IglesiaAnterior_DE { get; set; }
        public string PastorActual_DE { get; set; }
        public string SidoDisciplenado_DE { get; set; }
        public string DisciplinaVeces_DE { get; set; }
        public string DisciplinaCausas_DE { get; set; }
        public string FuncionesOcupadaActural_DE { get; set; }
        public string MinisteriosAnteriores_DE { get; set; }
        public string MinisteriosMayorFruto_DE { get; set; }
        public string MinisteriosMayorFrutoPorque_DE { get; set; }
        public string MinisterioLlamado_DE { get; set; }
        public string MetasVida_DE { get; set; }
        public string RespaldoIglesia_DE { get; set; }
        public string NivelEstudio_DA { get; set; }
        public string VezEspulsado_DA { get; set; }
        public string VezEspulsadoPorque_DA { get; set; }
        public int? Usuario_Id { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}

