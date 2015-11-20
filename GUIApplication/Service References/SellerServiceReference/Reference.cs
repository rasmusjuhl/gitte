﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUIApplication.SellerServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GUIApplication.SellerServiceReference.Seller))]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUIApplication.SellerServiceReference.Location LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiscField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobilField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUIApplication.SellerServiceReference.Location Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Misc {
            get {
                return this.MiscField;
            }
            set {
                if ((object.ReferenceEquals(this.MiscField, value) != true)) {
                    this.MiscField = value;
                    this.RaisePropertyChanged("Misc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobil {
            get {
                return this.MobilField;
            }
            set {
                if ((object.ReferenceEquals(this.MobilField, value) != true)) {
                    this.MobilField = value;
                    this.RaisePropertyChanged("Mobil");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Location", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Location : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ZipCodeField;
        
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
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ZipCode {
            get {
                return this.ZipCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipCodeField, value) != true)) {
                    this.ZipCodeField = value;
                    this.RaisePropertyChanged("ZipCode");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Seller", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Seller : GUIApplication.SellerServiceReference.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<GUIApplication.SellerServiceReference.Property> PropertiesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<GUIApplication.SellerServiceReference.Property> Properties {
            get {
                return this.PropertiesField;
            }
            set {
                if ((object.ReferenceEquals(this.PropertiesField, value) != true)) {
                    this.PropertiesField = value;
                    this.RaisePropertyChanged("Properties");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Property", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Property : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ConstructionYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FloorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double HouseSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUIApplication.SellerServiceReference.Location LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PropertySizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoomsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ConstructionYear {
            get {
                return this.ConstructionYearField;
            }
            set {
                if ((this.ConstructionYearField.Equals(value) != true)) {
                    this.ConstructionYearField = value;
                    this.RaisePropertyChanged("ConstructionYear");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Floors {
            get {
                return this.FloorsField;
            }
            set {
                if ((this.FloorsField.Equals(value) != true)) {
                    this.FloorsField = value;
                    this.RaisePropertyChanged("Floors");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double HouseSize {
            get {
                return this.HouseSizeField;
            }
            set {
                if ((this.HouseSizeField.Equals(value) != true)) {
                    this.HouseSizeField = value;
                    this.RaisePropertyChanged("HouseSize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUIApplication.SellerServiceReference.Location Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double PropertySize {
            get {
                return this.PropertySizeField;
            }
            set {
                if ((this.PropertySizeField.Equals(value) != true)) {
                    this.PropertySizeField = value;
                    this.RaisePropertyChanged("PropertySize");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Rooms {
            get {
                return this.RoomsField;
            }
            set {
                if ((this.RoomsField.Equals(value) != true)) {
                    this.RoomsField = value;
                    this.RaisePropertyChanged("Rooms");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SellerServiceReference.ISellerService")]
    public interface ISellerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISellerService/InsertSeller", ReplyAction="http://tempuri.org/ISellerService/InsertSellerResponse")]
        void InsertSeller(GUIApplication.SellerServiceReference.Seller seller);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISellerService/InsertSeller", ReplyAction="http://tempuri.org/ISellerService/InsertSellerResponse")]
        System.Threading.Tasks.Task InsertSellerAsync(GUIApplication.SellerServiceReference.Seller seller);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISellerService/GetSellerByPhone", ReplyAction="http://tempuri.org/ISellerService/GetSellerByPhoneResponse")]
        GUIApplication.SellerServiceReference.Seller GetSellerByPhone(string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISellerService/GetSellerByPhone", ReplyAction="http://tempuri.org/ISellerService/GetSellerByPhoneResponse")]
        System.Threading.Tasks.Task<GUIApplication.SellerServiceReference.Seller> GetSellerByPhoneAsync(string phone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISellerService/GetAllSellers", ReplyAction="http://tempuri.org/ISellerService/GetAllSellersResponse")]
        System.Collections.Generic.List<GUIApplication.SellerServiceReference.Seller> GetAllSellers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISellerService/GetAllSellers", ReplyAction="http://tempuri.org/ISellerService/GetAllSellersResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<GUIApplication.SellerServiceReference.Seller>> GetAllSellersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISellerService/UpdateSeller", ReplyAction="http://tempuri.org/ISellerService/UpdateSellerResponse")]
        void UpdateSeller(GUIApplication.SellerServiceReference.Seller seller, System.Collections.Generic.List<GUIApplication.SellerServiceReference.Property> properties, string name, string address, GUIApplication.SellerServiceReference.Location location, string phone, string mobil, string email, string misc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISellerService/UpdateSeller", ReplyAction="http://tempuri.org/ISellerService/UpdateSellerResponse")]
        System.Threading.Tasks.Task UpdateSellerAsync(GUIApplication.SellerServiceReference.Seller seller, System.Collections.Generic.List<GUIApplication.SellerServiceReference.Property> properties, string name, string address, GUIApplication.SellerServiceReference.Location location, string phone, string mobil, string email, string misc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISellerService/DeleteSeller", ReplyAction="http://tempuri.org/ISellerService/DeleteSellerResponse")]
        void DeleteSeller(GUIApplication.SellerServiceReference.Seller seller);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISellerService/DeleteSeller", ReplyAction="http://tempuri.org/ISellerService/DeleteSellerResponse")]
        System.Threading.Tasks.Task DeleteSellerAsync(GUIApplication.SellerServiceReference.Seller seller);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISellerServiceChannel : GUIApplication.SellerServiceReference.ISellerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SellerServiceClient : System.ServiceModel.ClientBase<GUIApplication.SellerServiceReference.ISellerService>, GUIApplication.SellerServiceReference.ISellerService {
        
        public SellerServiceClient() {
        }
        
        public SellerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SellerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SellerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SellerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertSeller(GUIApplication.SellerServiceReference.Seller seller) {
            base.Channel.InsertSeller(seller);
        }
        
        public System.Threading.Tasks.Task InsertSellerAsync(GUIApplication.SellerServiceReference.Seller seller) {
            return base.Channel.InsertSellerAsync(seller);
        }
        
        public GUIApplication.SellerServiceReference.Seller GetSellerByPhone(string phone) {
            return base.Channel.GetSellerByPhone(phone);
        }
        
        public System.Threading.Tasks.Task<GUIApplication.SellerServiceReference.Seller> GetSellerByPhoneAsync(string phone) {
            return base.Channel.GetSellerByPhoneAsync(phone);
        }
        
        public System.Collections.Generic.List<GUIApplication.SellerServiceReference.Seller> GetAllSellers() {
            return base.Channel.GetAllSellers();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<GUIApplication.SellerServiceReference.Seller>> GetAllSellersAsync() {
            return base.Channel.GetAllSellersAsync();
        }
        
        public void UpdateSeller(GUIApplication.SellerServiceReference.Seller seller, System.Collections.Generic.List<GUIApplication.SellerServiceReference.Property> properties, string name, string address, GUIApplication.SellerServiceReference.Location location, string phone, string mobil, string email, string misc) {
            base.Channel.UpdateSeller(seller, properties, name, address, location, phone, mobil, email, misc);
        }
        
        public System.Threading.Tasks.Task UpdateSellerAsync(GUIApplication.SellerServiceReference.Seller seller, System.Collections.Generic.List<GUIApplication.SellerServiceReference.Property> properties, string name, string address, GUIApplication.SellerServiceReference.Location location, string phone, string mobil, string email, string misc) {
            return base.Channel.UpdateSellerAsync(seller, properties, name, address, location, phone, mobil, email, misc);
        }
        
        public void DeleteSeller(GUIApplication.SellerServiceReference.Seller seller) {
            base.Channel.DeleteSeller(seller);
        }
        
        public System.Threading.Tasks.Task DeleteSellerAsync(GUIApplication.SellerServiceReference.Seller seller) {
            return base.Channel.DeleteSellerAsync(seller);
        }
    }
}
