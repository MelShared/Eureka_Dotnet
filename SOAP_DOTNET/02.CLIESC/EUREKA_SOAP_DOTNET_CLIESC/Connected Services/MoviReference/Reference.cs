﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EUREKA_SOAP_DOTNET_CLIESC.MoviReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomMovimientoModel", Namespace="http://schemas.datacontract.org/2004/07/WS_EUREKA_SOAP_DOTNET.Models")]
    [System.SerializableAttribute()]
    public partial class CustomMovimientoModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoCuentaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoEmpleadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoTipoMovimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CuentaReferenciaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaMovimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ImporteMovimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumeroMovimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoDescripcionField;
        
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
        public string CodigoCuenta {
            get {
                return this.CodigoCuentaField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoCuentaField, value) != true)) {
                    this.CodigoCuentaField = value;
                    this.RaisePropertyChanged("CodigoCuenta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoEmpleado {
            get {
                return this.CodigoEmpleadoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoEmpleadoField, value) != true)) {
                    this.CodigoEmpleadoField = value;
                    this.RaisePropertyChanged("CodigoEmpleado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoTipoMovimiento {
            get {
                return this.CodigoTipoMovimientoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoTipoMovimientoField, value) != true)) {
                    this.CodigoTipoMovimientoField = value;
                    this.RaisePropertyChanged("CodigoTipoMovimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CuentaReferencia {
            get {
                return this.CuentaReferenciaField;
            }
            set {
                if ((object.ReferenceEquals(this.CuentaReferenciaField, value) != true)) {
                    this.CuentaReferenciaField = value;
                    this.RaisePropertyChanged("CuentaReferencia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaMovimiento {
            get {
                return this.FechaMovimientoField;
            }
            set {
                if ((this.FechaMovimientoField.Equals(value) != true)) {
                    this.FechaMovimientoField = value;
                    this.RaisePropertyChanged("FechaMovimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ImporteMovimiento {
            get {
                return this.ImporteMovimientoField;
            }
            set {
                if ((this.ImporteMovimientoField.Equals(value) != true)) {
                    this.ImporteMovimientoField = value;
                    this.RaisePropertyChanged("ImporteMovimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int NumeroMovimiento {
            get {
                return this.NumeroMovimientoField;
            }
            set {
                if ((this.NumeroMovimientoField.Equals(value) != true)) {
                    this.NumeroMovimientoField = value;
                    this.RaisePropertyChanged("NumeroMovimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoDescripcion {
            get {
                return this.TipoDescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoDescripcionField, value) != true)) {
                    this.TipoDescripcionField = value;
                    this.RaisePropertyChanged("TipoDescripcion");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MoviReference.IMovimientoService")]
    public interface IMovimientoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientoService/ObtenerMovimientosPorCuenta", ReplyAction="http://tempuri.org/IMovimientoService/ObtenerMovimientosPorCuentaResponse")]
        EUREKA_SOAP_DOTNET_CLIESC.MoviReference.CustomMovimientoModel[] ObtenerMovimientosPorCuenta(string codigoCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientoService/ObtenerMovimientosPorCuenta", ReplyAction="http://tempuri.org/IMovimientoService/ObtenerMovimientosPorCuentaResponse")]
        System.Threading.Tasks.Task<EUREKA_SOAP_DOTNET_CLIESC.MoviReference.CustomMovimientoModel[]> ObtenerMovimientosPorCuentaAsync(string codigoCuenta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientoService/RegistrarMovimiento", ReplyAction="http://tempuri.org/IMovimientoService/RegistrarMovimientoResponse")]
        void RegistrarMovimiento(EUREKA_SOAP_DOTNET_CLIESC.MoviReference.CustomMovimientoModel movimiento);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMovimientoService/RegistrarMovimiento", ReplyAction="http://tempuri.org/IMovimientoService/RegistrarMovimientoResponse")]
        System.Threading.Tasks.Task RegistrarMovimientoAsync(EUREKA_SOAP_DOTNET_CLIESC.MoviReference.CustomMovimientoModel movimiento);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMovimientoServiceChannel : EUREKA_SOAP_DOTNET_CLIESC.MoviReference.IMovimientoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MovimientoServiceClient : System.ServiceModel.ClientBase<EUREKA_SOAP_DOTNET_CLIESC.MoviReference.IMovimientoService>, EUREKA_SOAP_DOTNET_CLIESC.MoviReference.IMovimientoService {
        
        public MovimientoServiceClient() {
        }
        
        public MovimientoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MovimientoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovimientoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovimientoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EUREKA_SOAP_DOTNET_CLIESC.MoviReference.CustomMovimientoModel[] ObtenerMovimientosPorCuenta(string codigoCuenta) {
            return base.Channel.ObtenerMovimientosPorCuenta(codigoCuenta);
        }
        
        public System.Threading.Tasks.Task<EUREKA_SOAP_DOTNET_CLIESC.MoviReference.CustomMovimientoModel[]> ObtenerMovimientosPorCuentaAsync(string codigoCuenta) {
            return base.Channel.ObtenerMovimientosPorCuentaAsync(codigoCuenta);
        }
        
        public void RegistrarMovimiento(EUREKA_SOAP_DOTNET_CLIESC.MoviReference.CustomMovimientoModel movimiento) {
            base.Channel.RegistrarMovimiento(movimiento);
        }
        
        public System.Threading.Tasks.Task RegistrarMovimientoAsync(EUREKA_SOAP_DOTNET_CLIESC.MoviReference.CustomMovimientoModel movimiento) {
            return base.Channel.RegistrarMovimientoAsync(movimiento);
        }
    }
}
