﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeWebservice1REST.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Employee", Namespace="http://schemas.datacontract.org/2004/07/EmployeeWebservice1REST")]
    [System.SerializableAttribute()]
    public partial class Employee : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int empIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string firstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string lastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
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
        public int empID {
            get {
                return this.empIDField;
            }
            set {
                if ((this.empIDField.Equals(value) != true)) {
                    this.empIDField = value;
                    this.RaisePropertyChanged("empID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.firstNameField, value) != true)) {
                    this.firstNameField = value;
                    this.RaisePropertyChanged("firstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.lastNameField, value) != true)) {
                    this.lastNameField = value;
                    this.RaisePropertyChanged("lastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.Nullable<int> age {
            get {
                return this.ageField;
            }
            set {
                if ((this.ageField.Equals(value) != true)) {
                    this.ageField = value;
                    this.RaisePropertyChanged("age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProductList", ReplyAction="http://tempuri.org/IService1/GetProductListResponse")]
        EmployeeWebservice1REST.ServiceReference1.Employee[] GetProductList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProductList", ReplyAction="http://tempuri.org/IService1/GetProductListResponse")]
        System.Threading.Tasks.Task<EmployeeWebservice1REST.ServiceReference1.Employee[]> GetProductListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEmployee", ReplyAction="http://tempuri.org/IService1/AddEmployeeResponse")]
        bool AddEmployee(EmployeeWebservice1REST.ServiceReference1.Employee eml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddEmployee", ReplyAction="http://tempuri.org/IService1/AddEmployeeResponse")]
        System.Threading.Tasks.Task<bool> AddEmployeeAsync(EmployeeWebservice1REST.ServiceReference1.Employee eml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEmployee", ReplyAction="http://tempuri.org/IService1/UpdateEmployeeResponse")]
        bool UpdateEmployee(EmployeeWebservice1REST.ServiceReference1.Employee eml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateEmployee", ReplyAction="http://tempuri.org/IService1/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task<bool> UpdateEmployeeAsync(EmployeeWebservice1REST.ServiceReference1.Employee eml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteEmployee", ReplyAction="http://tempuri.org/IService1/DeleteEmployeeResponse")]
        bool DeleteEmployee(int idE);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteEmployee", ReplyAction="http://tempuri.org/IService1/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task<bool> DeleteEmployeeAsync(int idE);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : EmployeeWebservice1REST.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<EmployeeWebservice1REST.ServiceReference1.IService1>, EmployeeWebservice1REST.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EmployeeWebservice1REST.ServiceReference1.Employee[] GetProductList() {
            return base.Channel.GetProductList();
        }
        
        public System.Threading.Tasks.Task<EmployeeWebservice1REST.ServiceReference1.Employee[]> GetProductListAsync() {
            return base.Channel.GetProductListAsync();
        }
        
        public bool AddEmployee(EmployeeWebservice1REST.ServiceReference1.Employee eml) {
            return base.Channel.AddEmployee(eml);
        }
        
        public System.Threading.Tasks.Task<bool> AddEmployeeAsync(EmployeeWebservice1REST.ServiceReference1.Employee eml) {
            return base.Channel.AddEmployeeAsync(eml);
        }
        
        public bool UpdateEmployee(EmployeeWebservice1REST.ServiceReference1.Employee eml) {
            return base.Channel.UpdateEmployee(eml);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateEmployeeAsync(EmployeeWebservice1REST.ServiceReference1.Employee eml) {
            return base.Channel.UpdateEmployeeAsync(eml);
        }
        
        public bool DeleteEmployee(int idE) {
            return base.Channel.DeleteEmployee(idE);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteEmployeeAsync(int idE) {
            return base.Channel.DeleteEmployeeAsync(idE);
        }
    }
}
