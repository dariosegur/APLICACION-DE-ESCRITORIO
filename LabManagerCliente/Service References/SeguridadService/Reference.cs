﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabManagerCliente.SeguridadService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoBase", Namespace="http://schemas.datacontract.org/2004/07/Dtos")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LabManagerCliente.SeguridadService.Lista_View_Menu))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LabManagerCliente.SeguridadService.View_Menu))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LabManagerCliente.SeguridadService.View_UsuarioAutentica))]
    public partial class DtoBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] TokenField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Error {
            get {
                return this.ErrorField;
            }
            set {
                if ((this.ErrorField.Equals(value) != true)) {
                    this.ErrorField = value;
                    this.RaisePropertyChanged("Error");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensaje {
            get {
                return this.MensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeField, value) != true)) {
                    this.MensajeField = value;
                    this.RaisePropertyChanged("Mensaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lista_View_Menu", Namespace="http://schemas.datacontract.org/2004/07/Dtos.Seguridad")]
    [System.SerializableAttribute()]
    public partial class Lista_View_Menu : LabManagerCliente.SeguridadService.DtoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LabManagerCliente.SeguridadService.View_Menu[] MenuOpcionesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LabManagerCliente.SeguridadService.View_Menu[] MenuOpciones {
            get {
                return this.MenuOpcionesField;
            }
            set {
                if ((object.ReferenceEquals(this.MenuOpcionesField, value) != true)) {
                    this.MenuOpcionesField = value;
                    this.RaisePropertyChanged("MenuOpciones");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="View_Menu", Namespace="http://schemas.datacontract.org/2004/07/Dtos.Seguridad")]
    [System.SerializableAttribute()]
    public partial class View_Menu : LabManagerCliente.SeguridadService.DtoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ActivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CreaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DestinoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaCreacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaModificacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GrupoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImagenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MenuIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> ModificaIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int OrdenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Activo {
            get {
                return this.ActivoField;
            }
            set {
                if ((this.ActivoField.Equals(value) != true)) {
                    this.ActivoField = value;
                    this.RaisePropertyChanged("Activo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CreaId {
            get {
                return this.CreaIdField;
            }
            set {
                if ((this.CreaIdField.Equals(value) != true)) {
                    this.CreaIdField = value;
                    this.RaisePropertyChanged("CreaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Destino {
            get {
                return this.DestinoField;
            }
            set {
                if ((object.ReferenceEquals(this.DestinoField, value) != true)) {
                    this.DestinoField = value;
                    this.RaisePropertyChanged("Destino");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaCreacion {
            get {
                return this.FechaCreacionField;
            }
            set {
                if ((this.FechaCreacionField.Equals(value) != true)) {
                    this.FechaCreacionField = value;
                    this.RaisePropertyChanged("FechaCreacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> FechaModificacion {
            get {
                return this.FechaModificacionField;
            }
            set {
                if ((this.FechaModificacionField.Equals(value) != true)) {
                    this.FechaModificacionField = value;
                    this.RaisePropertyChanged("FechaModificacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Grupo {
            get {
                return this.GrupoField;
            }
            set {
                if ((object.ReferenceEquals(this.GrupoField, value) != true)) {
                    this.GrupoField = value;
                    this.RaisePropertyChanged("Grupo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Imagen {
            get {
                return this.ImagenField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagenField, value) != true)) {
                    this.ImagenField = value;
                    this.RaisePropertyChanged("Imagen");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MenuId {
            get {
                return this.MenuIdField;
            }
            set {
                if ((this.MenuIdField.Equals(value) != true)) {
                    this.MenuIdField = value;
                    this.RaisePropertyChanged("MenuId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<long> ModificaId {
            get {
                return this.ModificaIdField;
            }
            set {
                if ((this.ModificaIdField.Equals(value) != true)) {
                    this.ModificaIdField = value;
                    this.RaisePropertyChanged("ModificaId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Orden {
            get {
                return this.OrdenField;
            }
            set {
                if ((this.OrdenField.Equals(value) != true)) {
                    this.OrdenField = value;
                    this.RaisePropertyChanged("Orden");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Texto {
            get {
                return this.TextoField;
            }
            set {
                if ((object.ReferenceEquals(this.TextoField, value) != true)) {
                    this.TextoField = value;
                    this.RaisePropertyChanged("Texto");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="View_UsuarioAutentica", Namespace="http://schemas.datacontract.org/2004/07/Dtos.Seguridad")]
    [System.SerializableAttribute()]
    public partial class View_UsuarioAutentica : LabManagerCliente.SeguridadService.DtoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BarCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> FacultadIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TipoUsuarioIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long UsuarioIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Apellidos {
            get {
                return this.ApellidosField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidosField, value) != true)) {
                    this.ApellidosField = value;
                    this.RaisePropertyChanged("Apellidos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BarCode {
            get {
                return this.BarCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.BarCodeField, value) != true)) {
                    this.BarCodeField = value;
                    this.RaisePropertyChanged("BarCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Documento {
            get {
                return this.DocumentoField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentoField, value) != true)) {
                    this.DocumentoField = value;
                    this.RaisePropertyChanged("Documento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> FacultadId {
            get {
                return this.FacultadIdField;
            }
            set {
                if ((this.FacultadIdField.Equals(value) != true)) {
                    this.FacultadIdField = value;
                    this.RaisePropertyChanged("FacultadId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TipoUsuarioId {
            get {
                return this.TipoUsuarioIdField;
            }
            set {
                if ((this.TipoUsuarioIdField.Equals(value) != true)) {
                    this.TipoUsuarioIdField = value;
                    this.RaisePropertyChanged("TipoUsuarioId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long UsuarioId {
            get {
                return this.UsuarioIdField;
            }
            set {
                if ((this.UsuarioIdField.Equals(value) != true)) {
                    this.UsuarioIdField = value;
                    this.RaisePropertyChanged("UsuarioId");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SeguridadService.ISeguridad")]
    public interface ISeguridad {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridad/Validar", ReplyAction="http://tempuri.org/ISeguridad/ValidarResponse")]
        LabManagerCliente.SeguridadService.View_UsuarioAutentica Validar(string User, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridad/Validar", ReplyAction="http://tempuri.org/ISeguridad/ValidarResponse")]
        System.Threading.Tasks.Task<LabManagerCliente.SeguridadService.View_UsuarioAutentica> ValidarAsync(string User, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridad/MenuUsuario", ReplyAction="http://tempuri.org/ISeguridad/MenuUsuarioResponse")]
        LabManagerCliente.SeguridadService.Lista_View_Menu MenuUsuario(long UsuarioId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridad/MenuUsuario", ReplyAction="http://tempuri.org/ISeguridad/MenuUsuarioResponse")]
        System.Threading.Tasks.Task<LabManagerCliente.SeguridadService.Lista_View_Menu> MenuUsuarioAsync(long UsuarioId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridad/MenuReportesUsuario", ReplyAction="http://tempuri.org/ISeguridad/MenuReportesUsuarioResponse")]
        LabManagerCliente.SeguridadService.Lista_View_Menu MenuReportesUsuario(long UsuarioId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridad/MenuReportesUsuario", ReplyAction="http://tempuri.org/ISeguridad/MenuReportesUsuarioResponse")]
        System.Threading.Tasks.Task<LabManagerCliente.SeguridadService.Lista_View_Menu> MenuReportesUsuarioAsync(long UsuarioId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridad/MenuPrincipalUsuario", ReplyAction="http://tempuri.org/ISeguridad/MenuPrincipalUsuarioResponse")]
        LabManagerCliente.SeguridadService.Lista_View_Menu MenuPrincipalUsuario(long UsuarioId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridad/MenuPrincipalUsuario", ReplyAction="http://tempuri.org/ISeguridad/MenuPrincipalUsuarioResponse")]
        System.Threading.Tasks.Task<LabManagerCliente.SeguridadService.Lista_View_Menu> MenuPrincipalUsuarioAsync(long UsuarioId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridad/MenuGestionUsuario", ReplyAction="http://tempuri.org/ISeguridad/MenuGestionUsuarioResponse")]
        LabManagerCliente.SeguridadService.Lista_View_Menu MenuGestionUsuario(long UsuarioId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISeguridad/MenuGestionUsuario", ReplyAction="http://tempuri.org/ISeguridad/MenuGestionUsuarioResponse")]
        System.Threading.Tasks.Task<LabManagerCliente.SeguridadService.Lista_View_Menu> MenuGestionUsuarioAsync(long UsuarioId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISeguridadChannel : LabManagerCliente.SeguridadService.ISeguridad, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SeguridadClient : System.ServiceModel.ClientBase<LabManagerCliente.SeguridadService.ISeguridad>, LabManagerCliente.SeguridadService.ISeguridad {
        
        public SeguridadClient() {
        }
        
        public SeguridadClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SeguridadClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SeguridadClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SeguridadClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LabManagerCliente.SeguridadService.View_UsuarioAutentica Validar(string User, string Password) {
            return base.Channel.Validar(User, Password);
        }
        
        public System.Threading.Tasks.Task<LabManagerCliente.SeguridadService.View_UsuarioAutentica> ValidarAsync(string User, string Password) {
            return base.Channel.ValidarAsync(User, Password);
        }
        
        public LabManagerCliente.SeguridadService.Lista_View_Menu MenuUsuario(long UsuarioId) {
            return base.Channel.MenuUsuario(UsuarioId);
        }
        
        public System.Threading.Tasks.Task<LabManagerCliente.SeguridadService.Lista_View_Menu> MenuUsuarioAsync(long UsuarioId) {
            return base.Channel.MenuUsuarioAsync(UsuarioId);
        }
        
        public LabManagerCliente.SeguridadService.Lista_View_Menu MenuReportesUsuario(long UsuarioId) {
            return base.Channel.MenuReportesUsuario(UsuarioId);
        }
        
        public System.Threading.Tasks.Task<LabManagerCliente.SeguridadService.Lista_View_Menu> MenuReportesUsuarioAsync(long UsuarioId) {
            return base.Channel.MenuReportesUsuarioAsync(UsuarioId);
        }
        
        public LabManagerCliente.SeguridadService.Lista_View_Menu MenuPrincipalUsuario(long UsuarioId) {
            return base.Channel.MenuPrincipalUsuario(UsuarioId);
        }
        
        public System.Threading.Tasks.Task<LabManagerCliente.SeguridadService.Lista_View_Menu> MenuPrincipalUsuarioAsync(long UsuarioId) {
            return base.Channel.MenuPrincipalUsuarioAsync(UsuarioId);
        }
        
        public LabManagerCliente.SeguridadService.Lista_View_Menu MenuGestionUsuario(long UsuarioId) {
            return base.Channel.MenuGestionUsuario(UsuarioId);
        }
        
        public System.Threading.Tasks.Task<LabManagerCliente.SeguridadService.Lista_View_Menu> MenuGestionUsuarioAsync(long UsuarioId) {
            return base.Channel.MenuGestionUsuarioAsync(UsuarioId);
        }
    }
}
