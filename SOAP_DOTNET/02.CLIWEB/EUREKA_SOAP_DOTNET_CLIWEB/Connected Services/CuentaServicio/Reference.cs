﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EUREKA_SOAP_DOTNET_CLIWEB.CuentaServicio {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CuentaServicio.ICuentaService")]
    public interface ICuentaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICuentaService/ActualizarSaldoYRegistrarMovimiento", ReplyAction="http://tempuri.org/ICuentaService/ActualizarSaldoYRegistrarMovimientoResponse")]
        bool ActualizarSaldoYRegistrarMovimiento(string codigoCuenta, string valorMovimiento, string tipo, string cuentaDest);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICuentaService/ActualizarSaldoYRegistrarMovimiento", ReplyAction="http://tempuri.org/ICuentaService/ActualizarSaldoYRegistrarMovimientoResponse")]
        System.Threading.Tasks.Task<bool> ActualizarSaldoYRegistrarMovimientoAsync(string codigoCuenta, string valorMovimiento, string tipo, string cuentaDest);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICuentaServiceChannel : EUREKA_SOAP_DOTNET_CLIWEB.CuentaServicio.ICuentaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CuentaServiceClient : System.ServiceModel.ClientBase<EUREKA_SOAP_DOTNET_CLIWEB.CuentaServicio.ICuentaService>, EUREKA_SOAP_DOTNET_CLIWEB.CuentaServicio.ICuentaService {
        
        public CuentaServiceClient() {
        }
        
        public CuentaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CuentaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CuentaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CuentaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ActualizarSaldoYRegistrarMovimiento(string codigoCuenta, string valorMovimiento, string tipo, string cuentaDest) {
            return base.Channel.ActualizarSaldoYRegistrarMovimiento(codigoCuenta, valorMovimiento, tipo, cuentaDest);
        }
        
        public System.Threading.Tasks.Task<bool> ActualizarSaldoYRegistrarMovimientoAsync(string codigoCuenta, string valorMovimiento, string tipo, string cuentaDest) {
            return base.Channel.ActualizarSaldoYRegistrarMovimientoAsync(codigoCuenta, valorMovimiento, tipo, cuentaDest);
        }
    }
}
