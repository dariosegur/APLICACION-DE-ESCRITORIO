﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabManagerCliente.DeudoresService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DtoBase", Namespace="http://schemas.datacontract.org/2004/07/Dtos")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LabManagerCliente.DeudoresService.View_Deudores))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(LabManagerCliente.DeudoresService.Lista_View_Deudores))]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="View_Deudores", Namespace="http://schemas.datacontract.org/2004/07/Dtos.Reportes")]
    [System.SerializableAttribute()]
    public partial class View_Deudores : LabManagerCliente.DeudoresService.DtoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreadaPorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocumentoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FacultadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaCreacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> FechaModificacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ModificadaPorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ValorField;
        
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
        public string CreadaPor {
            get {
                return this.CreadaPorField;
            }
            set {
                if ((object.ReferenceEquals(this.CreadaPorField, value) != true)) {
                    this.CreadaPorField = value;
                    this.RaisePropertyChanged("CreadaPor");
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
        public string Facultad {
            get {
                return this.FacultadField;
            }
            set {
                if ((object.ReferenceEquals(this.FacultadField, value) != true)) {
                    this.FacultadField = value;
                    this.RaisePropertyChanged("Facultad");
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
        public string ModificadaPor {
            get {
                return this.ModificadaPorField;
            }
            set {
                if ((object.ReferenceEquals(this.ModificadaPorField, value) != true)) {
                    this.ModificadaPorField = value;
                    this.RaisePropertyChanged("ModificadaPor");
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
        public int Valor {
            get {
                return this.ValorField;
            }
            set {
                if ((this.ValorField.Equals(value) != true)) {
                    this.ValorField = value;
                    this.RaisePropertyChanged("Valor");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lista_View_Deudores", Namespace="http://schemas.datacontract.org/2004/07/Dtos.Reportes")]
    [System.SerializableAttribute()]
    public partial class Lista_View_Deudores : LabManagerCliente.DeudoresService.DtoBase {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LabManagerCliente.DeudoresService.View_Deudores[] ItemsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LabManagerCliente.DeudoresService.View_Deudores[] Items {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DeudoresService.IDeudores")]
    public interface IDeudores {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeudores/getDeudores", ReplyAction="http://tempuri.org/IDeudores/getDeudoresResponse")]
        LabManagerCliente.DeudoresService.Lista_View_Deudores getDeudores();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDeudores/getDeudores", ReplyAction="http://tempuri.org/IDeudores/getDeudoresResponse")]
        System.Threading.Tasks.Task<LabManagerCliente.DeudoresService.Lista_View_Deudores> getDeudoresAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDeudoresChannel : LabManagerCliente.DeudoresService.IDeudores, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DeudoresClient : System.ServiceModel.ClientBase<LabManagerCliente.DeudoresService.IDeudores>, LabManagerCliente.DeudoresService.IDeudores {
        
        public DeudoresClient() {
        }
        
        public DeudoresClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DeudoresClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeudoresClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DeudoresClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LabManagerCliente.DeudoresService.Lista_View_Deudores getDeudores() {
            return base.Channel.getDeudores();
        }
        
        public System.Threading.Tasks.Task<LabManagerCliente.DeudoresService.Lista_View_Deudores> getDeudoresAsync() {
            return base.Channel.getDeudoresAsync();
        }
    }
}
