﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarsDiagnosticReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CommonData", Namespace="http://schemas.datacontract.org/2004/07/Eldan.DiagnosticServicesLib.CarsDiagnosti" +
        "c")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarsDiagnosticReference.PointerDiagnosticData))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarsDiagnosticReference.IturanDiagnosticData))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarsDiagnosticReference.InetDiagnosticData))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarsDiagnosticReference.CarData))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(CarsDiagnosticReference.EdiDiagnosticData))]
    public partial class CommonData : object
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PointerDiagnosticData", Namespace="http://schemas.datacontract.org/2004/07/Eldan.DiagnosticServicesLib.CarsDiagnosti" +
        "c")]
    public partial class PointerDiagnosticData : CarsDiagnosticReference.CommonData
    {
        
        private string PointerCarModelNameField;
        
        private int PointerCarNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PointerCarModelName
        {
            get
            {
                return this.PointerCarModelNameField;
            }
            set
            {
                this.PointerCarModelNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PointerCarNumber
        {
            get
            {
                return this.PointerCarNumberField;
            }
            set
            {
                this.PointerCarNumberField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="IturanDiagnosticData", Namespace="http://schemas.datacontract.org/2004/07/Eldan.DiagnosticServicesLib.CarsDiagnosti" +
        "c")]
    public partial class IturanDiagnosticData : CarsDiagnosticReference.CommonData
    {
        
        private string IturanCarModelNameField;
        
        private int IturanCarNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IturanCarModelName
        {
            get
            {
                return this.IturanCarModelNameField;
            }
            set
            {
                this.IturanCarModelNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IturanCarNumber
        {
            get
            {
                return this.IturanCarNumberField;
            }
            set
            {
                this.IturanCarNumberField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="InetDiagnosticData", Namespace="http://schemas.datacontract.org/2004/07/Eldan.DiagnosticServicesLib.CarsDiagnosti" +
        "c")]
    public partial class InetDiagnosticData : CarsDiagnosticReference.CommonData
    {
        
        private string InetCarModelNameField;
        
        private int InetCarNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InetCarModelName
        {
            get
            {
                return this.InetCarModelNameField;
            }
            set
            {
                this.InetCarModelNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int InetCarNumber
        {
            get
            {
                return this.InetCarNumberField;
            }
            set
            {
                this.InetCarNumberField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CarData", Namespace="http://schemas.datacontract.org/2004/07/Eldan.DiagnosticServicesLib.CarsDiagnosti" +
        "c")]
    public partial class CarData : CarsDiagnosticReference.CommonData
    {
        
        private string CarModelNameField;
        
        private int CarNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CarModelName
        {
            get
            {
                return this.CarModelNameField;
            }
            set
            {
                this.CarModelNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CarNumber
        {
            get
            {
                return this.CarNumberField;
            }
            set
            {
                this.CarNumberField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EdiDiagnosticData", Namespace="http://schemas.datacontract.org/2004/07/Eldan.DiagnosticServicesLib.CarsDiagnosti" +
        "c")]
    public partial class EdiDiagnosticData : CarsDiagnosticReference.CommonData
    {
        
        private string EdiCarModelNameField;
        
        private int EdiCarNumberField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EdiCarModelName
        {
            get
            {
                return this.EdiCarModelNameField;
            }
            set
            {
                this.EdiCarModelNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int EdiCarNumber
        {
            get
            {
                return this.EdiCarNumberField;
            }
            set
            {
                this.EdiCarNumberField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarsDiagnosticReference.ICarsDiagnosticService")]
    public interface ICarsDiagnosticService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarsDiagnosticService/UpdateSuppliersData", ReplyAction="http://tempuri.org/ICarsDiagnosticService/UpdateSuppliersDataResponse")]
        void UpdateSuppliersData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarsDiagnosticService/UpdateSuppliersData", ReplyAction="http://tempuri.org/ICarsDiagnosticService/UpdateSuppliersDataResponse")]
        System.Threading.Tasks.Task UpdateSuppliersDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarsDiagnosticService/UpdateSupplierData", ReplyAction="http://tempuri.org/ICarsDiagnosticService/UpdateSupplierDataResponse")]
        void UpdateSupplierData(System.Collections.Generic.List<int> carsNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarsDiagnosticService/UpdateSupplierData", ReplyAction="http://tempuri.org/ICarsDiagnosticService/UpdateSupplierDataResponse")]
        System.Threading.Tasks.Task UpdateSupplierDataAsync(System.Collections.Generic.List<int> carsNumber);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICarsDiagnosticService/UpdateEdiData")]
        void UpdateEdiData(CarsDiagnosticReference.EdiDiagnosticData ediDiagnosticData, string LoggerSessionID);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICarsDiagnosticService/UpdateEdiData")]
        System.Threading.Tasks.Task UpdateEdiDataAsync(CarsDiagnosticReference.EdiDiagnosticData ediDiagnosticData, string LoggerSessionID);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICarsDiagnosticService/UpdatePointerData")]
        void UpdatePointerData(CarsDiagnosticReference.PointerDiagnosticData pointerDiagnosticData, string LoggerSessionID);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICarsDiagnosticService/UpdatePointerData")]
        System.Threading.Tasks.Task UpdatePointerDataAsync(CarsDiagnosticReference.PointerDiagnosticData pointerDiagnosticData, string LoggerSessionID);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICarsDiagnosticService/UpdateIturanData")]
        void UpdateIturanData(CarsDiagnosticReference.IturanDiagnosticData ituranDiagnosticData, string LoggerSessionID);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICarsDiagnosticService/UpdateIturanData")]
        System.Threading.Tasks.Task UpdateIturanDataAsync(CarsDiagnosticReference.IturanDiagnosticData ituranDiagnosticData, string LoggerSessionID);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICarsDiagnosticService/UpdateInetData")]
        void UpdateInetData(CarsDiagnosticReference.InetDiagnosticData inetDiagnosticData, string LoggerSessionID);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICarsDiagnosticService/UpdateInetData")]
        System.Threading.Tasks.Task UpdateInetDataAsync(CarsDiagnosticReference.InetDiagnosticData inetDiagnosticData, string LoggerSessionID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarsDiagnosticService/GetCarData", ReplyAction="http://tempuri.org/ICarsDiagnosticService/GetCarDataResponse")]
        CarsDiagnosticReference.CarData GetCarData(int carNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarsDiagnosticService/GetCarData", ReplyAction="http://tempuri.org/ICarsDiagnosticService/GetCarDataResponse")]
        System.Threading.Tasks.Task<CarsDiagnosticReference.CarData> GetCarDataAsync(int carNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarsDiagnosticService/CalibrateSupplierCar", ReplyAction="http://tempuri.org/ICarsDiagnosticService/CalibrateSupplierCarResponse")]
        void CalibrateSupplierCar(int carNumber, int KM);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarsDiagnosticService/CalibrateSupplierCar", ReplyAction="http://tempuri.org/ICarsDiagnosticService/CalibrateSupplierCarResponse")]
        System.Threading.Tasks.Task CalibrateSupplierCarAsync(int carNumber, int KM);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface ICarsDiagnosticServiceChannel : CarsDiagnosticReference.ICarsDiagnosticService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class CarsDiagnosticServiceClient : System.ServiceModel.ClientBase<CarsDiagnosticReference.ICarsDiagnosticService>, CarsDiagnosticReference.ICarsDiagnosticService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CarsDiagnosticServiceClient() : 
                base(CarsDiagnosticServiceClient.GetDefaultBinding(), CarsDiagnosticServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICarsDiagnosticService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CarsDiagnosticServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(CarsDiagnosticServiceClient.GetBindingForEndpoint(endpointConfiguration), CarsDiagnosticServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CarsDiagnosticServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CarsDiagnosticServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CarsDiagnosticServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CarsDiagnosticServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CarsDiagnosticServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void UpdateSuppliersData()
        {
            base.Channel.UpdateSuppliersData();
        }
        
        public System.Threading.Tasks.Task UpdateSuppliersDataAsync()
        {
            return base.Channel.UpdateSuppliersDataAsync();
        }
        
        public void UpdateSupplierData(System.Collections.Generic.List<int> carsNumber)
        {
            base.Channel.UpdateSupplierData(carsNumber);
        }
        
        public System.Threading.Tasks.Task UpdateSupplierDataAsync(System.Collections.Generic.List<int> carsNumber)
        {
            return base.Channel.UpdateSupplierDataAsync(carsNumber);
        }
        
        public void UpdateEdiData(CarsDiagnosticReference.EdiDiagnosticData ediDiagnosticData, string LoggerSessionID)
        {
            base.Channel.UpdateEdiData(ediDiagnosticData, LoggerSessionID);
        }
        
        public System.Threading.Tasks.Task UpdateEdiDataAsync(CarsDiagnosticReference.EdiDiagnosticData ediDiagnosticData, string LoggerSessionID)
        {
            return base.Channel.UpdateEdiDataAsync(ediDiagnosticData, LoggerSessionID);
        }
        
        public void UpdatePointerData(CarsDiagnosticReference.PointerDiagnosticData pointerDiagnosticData, string LoggerSessionID)
        {
            base.Channel.UpdatePointerData(pointerDiagnosticData, LoggerSessionID);
        }
        
        public System.Threading.Tasks.Task UpdatePointerDataAsync(CarsDiagnosticReference.PointerDiagnosticData pointerDiagnosticData, string LoggerSessionID)
        {
            return base.Channel.UpdatePointerDataAsync(pointerDiagnosticData, LoggerSessionID);
        }
        
        public void UpdateIturanData(CarsDiagnosticReference.IturanDiagnosticData ituranDiagnosticData, string LoggerSessionID)
        {
            base.Channel.UpdateIturanData(ituranDiagnosticData, LoggerSessionID);
        }
        
        public System.Threading.Tasks.Task UpdateIturanDataAsync(CarsDiagnosticReference.IturanDiagnosticData ituranDiagnosticData, string LoggerSessionID)
        {
            return base.Channel.UpdateIturanDataAsync(ituranDiagnosticData, LoggerSessionID);
        }
        
        public void UpdateInetData(CarsDiagnosticReference.InetDiagnosticData inetDiagnosticData, string LoggerSessionID)
        {
            base.Channel.UpdateInetData(inetDiagnosticData, LoggerSessionID);
        }
        
        public System.Threading.Tasks.Task UpdateInetDataAsync(CarsDiagnosticReference.InetDiagnosticData inetDiagnosticData, string LoggerSessionID)
        {
            return base.Channel.UpdateInetDataAsync(inetDiagnosticData, LoggerSessionID);
        }
        
        public CarsDiagnosticReference.CarData GetCarData(int carNumber)
        {
            return base.Channel.GetCarData(carNumber);
        }
        
        public System.Threading.Tasks.Task<CarsDiagnosticReference.CarData> GetCarDataAsync(int carNumber)
        {
            return base.Channel.GetCarDataAsync(carNumber);
        }
        
        public void CalibrateSupplierCar(int carNumber, int KM)
        {
            base.Channel.CalibrateSupplierCar(carNumber, KM);
        }
        
        public System.Threading.Tasks.Task CalibrateSupplierCarAsync(int carNumber, int KM)
        {
            return base.Channel.CalibrateSupplierCarAsync(carNumber, KM);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICarsDiagnosticService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICarsDiagnosticService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:59041/CarsDiagnosticService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CarsDiagnosticServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICarsDiagnosticService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CarsDiagnosticServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICarsDiagnosticService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ICarsDiagnosticService,
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarsDiagnosticReference.IScheduler")]
    public interface IScheduler
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduler/Refresh", ReplyAction="http://tempuri.org/IScheduler/RefreshResponse")]
        void Refresh(string taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduler/Refresh", ReplyAction="http://tempuri.org/IScheduler/RefreshResponse")]
        System.Threading.Tasks.Task RefreshAsync(string taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduler/Flush", ReplyAction="http://tempuri.org/IScheduler/FlushResponse")]
        void Flush();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IScheduler/Flush", ReplyAction="http://tempuri.org/IScheduler/FlushResponse")]
        System.Threading.Tasks.Task FlushAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public interface ISchedulerChannel : CarsDiagnosticReference.IScheduler, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    public partial class SchedulerClient : System.ServiceModel.ClientBase<CarsDiagnosticReference.IScheduler>, CarsDiagnosticReference.IScheduler
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SchedulerClient() : 
                base(SchedulerClient.GetDefaultBinding(), SchedulerClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IScheduler.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SchedulerClient(EndpointConfiguration endpointConfiguration) : 
                base(SchedulerClient.GetBindingForEndpoint(endpointConfiguration), SchedulerClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SchedulerClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SchedulerClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SchedulerClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SchedulerClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SchedulerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void Refresh(string taskId)
        {
            base.Channel.Refresh(taskId);
        }
        
        public System.Threading.Tasks.Task RefreshAsync(string taskId)
        {
            return base.Channel.RefreshAsync(taskId);
        }
        
        public void Flush()
        {
            base.Channel.Flush();
        }
        
        public System.Threading.Tasks.Task FlushAsync()
        {
            return base.Channel.FlushAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IScheduler))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IScheduler))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:59041/CarsDiagnosticService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SchedulerClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IScheduler);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SchedulerClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IScheduler);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IScheduler,
        }
    }
}