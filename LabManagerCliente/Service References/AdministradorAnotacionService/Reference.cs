﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabManagerCliente.AdministradorAnotacionService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoBase", Namespace="http://schemas.datacontract.org/2004/07/Dtos")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LabManagerCliente.AdministradorAnotacionService.View_Anotaciones))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LabManagerCliente.AdministradorAnotacionService.Lista_View_EstadoAnotacion))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LabManagerCliente.AdministradorAnotacionService.EstadoAnotacion))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LabManagerCliente.AdministradorAnotacionService.Lista_View_Anotaciones))]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="View_Anotaciones", Namespace="http://schemas.datacontract.org/2004/07/Dtos.Basico")]
    [System.SerializableAttribute()]
    public partial class View_Anotaciones : LabManagerCliente.AdministradorAnotacionService.DtoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long AnotacionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long CreadoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoAnotacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstadoAnotacionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaCreacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaModificacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<long> ModificadoIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreCreadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreModificaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long UsuarioIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long AnotacionId {
            get {
                return this.AnotacionIdField;
            }
            set {
                if ((this.AnotacionIdField.Equals(value) != true)) {
                    this.AnotacionIdField = value;
                    this.RaisePropertyChanged("AnotacionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long CreadoId {
            get {
                return this.CreadoIdField;
            }
            set {
                if ((this.CreadoIdField.Equals(value) != true)) {
                    this.CreadoIdField = value;
                    this.RaisePropertyChanged("CreadoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EstadoAnotacion {
            get {
                return this.EstadoAnotacionField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoAnotacionField, value) != true)) {
                    this.EstadoAnotacionField = value;
                    this.RaisePropertyChanged("EstadoAnotacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EstadoAnotacionId {
            get {
                return this.EstadoAnotacionIdField;
            }
            set {
                if ((this.EstadoAnotacionIdField.Equals(value) != true)) {
                    this.EstadoAnotacionIdField = value;
                    this.RaisePropertyChanged("EstadoAnotacionId");
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
        public System.Nullable<long> ModificadoId {
            get {
                return this.ModificadoIdField;
            }
            set {
                if ((this.ModificadoIdField.Equals(value) != true)) {
                    this.ModificadoIdField = value;
                    this.RaisePropertyChanged("ModificadoId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreCreador {
            get {
                return this.NombreCreadorField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreCreadorField, value) != true)) {
                    this.NombreCreadorField = value;
                    this.RaisePropertyChanged("NombreCreador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreModifica {
            get {
                return this.NombreModificaField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreModificaField, value) != true)) {
                    this.NombreModificaField = value;
                    this.RaisePropertyChanged("NombreModifica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Usuario {
            get {
                return this.UsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioField, value) != true)) {
                    this.UsuarioField = value;
                    this.RaisePropertyChanged("Usuario");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lista_View_EstadoAnotacion", Namespace="http://schemas.datacontract.org/2004/07/Dtos.Basico")]
    [System.SerializableAttribute()]
    public partial class Lista_View_EstadoAnotacion : LabManagerCliente.AdministradorAnotacionService.DtoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LabManagerCliente.AdministradorAnotacionService.EstadoAnotacion[] ItemsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LabManagerCliente.AdministradorAnotacionService.EstadoAnotacion[] Items {
            get {
                return this.ItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemsField, value) != true)) {
                    this.ItemsField = value;
                    this.RaisePropertyChanged("Items");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EstadoAnotacion", Namespace="http://schemas.datacontract.org/2004/07/Dtos.Basico")]
    [System.SerializableAttribute()]
    public partial class EstadoAnotacion : LabManagerCliente.AdministradorAnotacionService.DtoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int EstadoAnotacionIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EstadoAnotacionId {
            get {
                return this.EstadoAnotacionIdField;
            }
            set {
                if ((this.EstadoAnotacionIdField.Equals(value) != true)) {
                    this.EstadoAnotacionIdField = value;
                    this.RaisePropertyChanged("EstadoAnotacionId");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lista_View_Anotaciones", Namespace="http://schemas.datacontract.org/2004/07/Dtos.Basico")]
    [System.SerializableAttribute()]
    public partial class Lista_View_Anotaciones : LabManagerCliente.AdministradorAnotacionService.DtoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LabManagerCliente.AdministradorAnotacionService.View_Anotaciones[] ItemsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LabManagerCliente.AdministradorAnotacionService.View_Anotaciones[] Items {
            get {
                return this.ItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemsField, value) != true)) {
                    this.ItemsField = value;
                    this.RaisePropertyChanged("Items");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdministradorAnotacionService.IAdministradorAnotacion")]
    public interface IAdministradorAnotacion {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorAnotacion/getAnotaciones", ReplyAction="http://tempuri.org/IAdministradorAnotacion/getAnotacionesResponse")]
        LabManagerCliente.AdministradorAnotacionService.Lista_View_Anotaciones getAnotaciones(long UsuarioId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorAnotacion/getAnotaciones", ReplyAction="http://tempuri.org/IAdministradorAnotacion/getAnotacionesResponse")]
        System.Threading.Tasks.Task<LabManagerCliente.AdministradorAnotacionService.Lista_View_Anotaciones> getAnotacionesAsync(long UsuarioId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorAnotacion/AddAnotacion", ReplyAction="http://tempuri.org/IAdministradorAnotacion/AddAnotacionResponse")]
        LabManagerCliente.AdministradorAnotacionService.DtoBase AddAnotacion(LabManagerCliente.AdministradorAnotacionService.View_Anotaciones newAnotacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorAnotacion/AddAnotacion", ReplyAction="http://tempuri.org/IAdministradorAnotacion/AddAnotacionResponse")]
        System.Threading.Tasks.Task<LabManagerCliente.AdministradorAnotacionService.DtoBase> AddAnotacionAsync(LabManagerCliente.AdministradorAnotacionService.View_Anotaciones newAnotacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorAnotacion/EditAnotacion", ReplyAction="http://tempuri.org/IAdministradorAnotacion/EditAnotacionResponse")]
        LabManagerCliente.AdministradorAnotacionService.DtoBase EditAnotacion([System.ServiceModel.MessageParameterAttribute(Name="editAnotacion")] LabManagerCliente.AdministradorAnotacionService.View_Anotaciones editAnotacion1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorAnotacion/EditAnotacion", ReplyAction="http://tempuri.org/IAdministradorAnotacion/EditAnotacionResponse")]
        System.Threading.Tasks.Task<LabManagerCliente.AdministradorAnotacionService.DtoBase> EditAnotacionAsync(LabManagerCliente.AdministradorAnotacionService.View_Anotaciones editAnotacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorAnotacion/getEstadosAnotacion", ReplyAction="http://tempuri.org/IAdministradorAnotacion/getEstadosAnotacionResponse")]
        LabManagerCliente.AdministradorAnotacionService.Lista_View_EstadoAnotacion getEstadosAnotacion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdministradorAnotacion/getEstadosAnotacion", ReplyAction="http://tempuri.org/IAdministradorAnotacion/getEstadosAnotacionResponse")]
        System.Threading.Tasks.Task<LabManagerCliente.AdministradorAnotacionService.Lista_View_EstadoAnotacion> getEstadosAnotacionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdministradorAnotacionChannel : LabManagerCliente.AdministradorAnotacionService.IAdministradorAnotacion, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdministradorAnotacionClient : System.ServiceModel.ClientBase<LabManagerCliente.AdministradorAnotacionService.IAdministradorAnotacion>, LabManagerCliente.AdministradorAnotacionService.IAdministradorAnotacion {
        
        public AdministradorAnotacionClient() {
        }
        
        public AdministradorAnotacionClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdministradorAnotacionClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdministradorAnotacionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdministradorAnotacionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LabManagerCliente.AdministradorAnotacionService.Lista_View_Anotaciones getAnotaciones(long UsuarioId) {
            return base.Channel.getAnotaciones(UsuarioId);
        }
        
        public System.Threading.Tasks.Task<LabManagerCliente.AdministradorAnotacionService.Lista_View_Anotaciones> getAnotacionesAsync(long UsuarioId) {
            return base.Channel.getAnotacionesAsync(UsuarioId);
        }
        
        public LabManagerCliente.AdministradorAnotacionService.DtoBase AddAnotacion(LabManagerCliente.AdministradorAnotacionService.View_Anotaciones newAnotacion) {
            return base.Channel.AddAnotacion(newAnotacion);
        }
        
        public System.Threading.Tasks.Task<LabManagerCliente.AdministradorAnotacionService.DtoBase> AddAnotacionAsync(LabManagerCliente.AdministradorAnotacionService.View_Anotaciones newAnotacion) {
            return base.Channel.AddAnotacionAsync(newAnotacion);
        }
        
        public LabManagerCliente.AdministradorAnotacionService.DtoBase EditAnotacion(LabManagerCliente.AdministradorAnotacionService.View_Anotaciones editAnotacion1) {
            return base.Channel.EditAnotacion(editAnotacion1);
        }
        
        public System.Threading.Tasks.Task<LabManagerCliente.AdministradorAnotacionService.DtoBase> EditAnotacionAsync(LabManagerCliente.AdministradorAnotacionService.View_Anotaciones editAnotacion) {
            return base.Channel.EditAnotacionAsync(editAnotacion);
        }
        
        public LabManagerCliente.AdministradorAnotacionService.Lista_View_EstadoAnotacion getEstadosAnotacion() {
            return base.Channel.getEstadosAnotacion();
        }
        
        public System.Threading.Tasks.Task<LabManagerCliente.AdministradorAnotacionService.Lista_View_EstadoAnotacion> getEstadosAnotacionAsync() {
            return base.Channel.getEstadosAnotacionAsync();
        }
    }
}
