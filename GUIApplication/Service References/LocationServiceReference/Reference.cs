﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUIApplication.LocationServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Location", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Location : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUIApplication.LocationServiceReference.Buyer[] BuyersField;
        
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
        public GUIApplication.LocationServiceReference.Buyer[] Buyers {
            get {
                return this.BuyersField;
            }
            set {
                if ((object.ReferenceEquals(this.BuyersField, value) != true)) {
                    this.BuyersField = value;
                    this.RaisePropertyChanged("Buyers");
                }
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Buyer", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Buyer : GUIApplication.LocationServiceReference.Person {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AllowedEmailSpamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BankField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BuyerApprovedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ContactAllowedByBoligOneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ContactAllowedByRealField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double DesiredRoomsMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double DesiredRoomsMinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstateTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool InRKIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool LivesForRentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUIApplication.LocationServiceReference.Location[] LocationsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LotSizeMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double LotSizeMinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MaxPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MinPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OtherPrefField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool OwnesHouseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ProbertySizeMaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double ProbertySizeMinField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUIApplication.LocationServiceReference.Property[] PropertiesField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AllowedEmailSpam {
            get {
                return this.AllowedEmailSpamField;
            }
            set {
                if ((this.AllowedEmailSpamField.Equals(value) != true)) {
                    this.AllowedEmailSpamField = value;
                    this.RaisePropertyChanged("AllowedEmailSpam");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Bank {
            get {
                return this.BankField;
            }
            set {
                if ((object.ReferenceEquals(this.BankField, value) != true)) {
                    this.BankField = value;
                    this.RaisePropertyChanged("Bank");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BuyerApproved {
            get {
                return this.BuyerApprovedField;
            }
            set {
                if ((this.BuyerApprovedField.Equals(value) != true)) {
                    this.BuyerApprovedField = value;
                    this.RaisePropertyChanged("BuyerApproved");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ContactAllowedByBoligOne {
            get {
                return this.ContactAllowedByBoligOneField;
            }
            set {
                if ((this.ContactAllowedByBoligOneField.Equals(value) != true)) {
                    this.ContactAllowedByBoligOneField = value;
                    this.RaisePropertyChanged("ContactAllowedByBoligOne");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ContactAllowedByReal {
            get {
                return this.ContactAllowedByRealField;
            }
            set {
                if ((this.ContactAllowedByRealField.Equals(value) != true)) {
                    this.ContactAllowedByRealField = value;
                    this.RaisePropertyChanged("ContactAllowedByReal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double DesiredRoomsMax {
            get {
                return this.DesiredRoomsMaxField;
            }
            set {
                if ((this.DesiredRoomsMaxField.Equals(value) != true)) {
                    this.DesiredRoomsMaxField = value;
                    this.RaisePropertyChanged("DesiredRoomsMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double DesiredRoomsMin {
            get {
                return this.DesiredRoomsMinField;
            }
            set {
                if ((this.DesiredRoomsMinField.Equals(value) != true)) {
                    this.DesiredRoomsMinField = value;
                    this.RaisePropertyChanged("DesiredRoomsMin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EstateType {
            get {
                return this.EstateTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.EstateTypeField, value) != true)) {
                    this.EstateTypeField = value;
                    this.RaisePropertyChanged("EstateType");
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
        public bool InRKI {
            get {
                return this.InRKIField;
            }
            set {
                if ((this.InRKIField.Equals(value) != true)) {
                    this.InRKIField = value;
                    this.RaisePropertyChanged("InRKI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool LivesForRent {
            get {
                return this.LivesForRentField;
            }
            set {
                if ((this.LivesForRentField.Equals(value) != true)) {
                    this.LivesForRentField = value;
                    this.RaisePropertyChanged("LivesForRent");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUIApplication.LocationServiceReference.Location[] Locations {
            get {
                return this.LocationsField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationsField, value) != true)) {
                    this.LocationsField = value;
                    this.RaisePropertyChanged("Locations");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LotSizeMax {
            get {
                return this.LotSizeMaxField;
            }
            set {
                if ((this.LotSizeMaxField.Equals(value) != true)) {
                    this.LotSizeMaxField = value;
                    this.RaisePropertyChanged("LotSizeMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double LotSizeMin {
            get {
                return this.LotSizeMinField;
            }
            set {
                if ((this.LotSizeMinField.Equals(value) != true)) {
                    this.LotSizeMinField = value;
                    this.RaisePropertyChanged("LotSizeMin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MaxPrice {
            get {
                return this.MaxPriceField;
            }
            set {
                if ((this.MaxPriceField.Equals(value) != true)) {
                    this.MaxPriceField = value;
                    this.RaisePropertyChanged("MaxPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double MinPrice {
            get {
                return this.MinPriceField;
            }
            set {
                if ((this.MinPriceField.Equals(value) != true)) {
                    this.MinPriceField = value;
                    this.RaisePropertyChanged("MinPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OtherPref {
            get {
                return this.OtherPrefField;
            }
            set {
                if ((object.ReferenceEquals(this.OtherPrefField, value) != true)) {
                    this.OtherPrefField = value;
                    this.RaisePropertyChanged("OtherPref");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool OwnesHouse {
            get {
                return this.OwnesHouseField;
            }
            set {
                if ((this.OwnesHouseField.Equals(value) != true)) {
                    this.OwnesHouseField = value;
                    this.RaisePropertyChanged("OwnesHouse");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ProbertySizeMax {
            get {
                return this.ProbertySizeMaxField;
            }
            set {
                if ((this.ProbertySizeMaxField.Equals(value) != true)) {
                    this.ProbertySizeMaxField = value;
                    this.RaisePropertyChanged("ProbertySizeMax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double ProbertySizeMin {
            get {
                return this.ProbertySizeMinField;
            }
            set {
                if ((this.ProbertySizeMinField.Equals(value) != true)) {
                    this.ProbertySizeMinField = value;
                    this.RaisePropertyChanged("ProbertySizeMin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public GUIApplication.LocationServiceReference.Property[] Properties {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(GUIApplication.LocationServiceReference.Buyer))]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiscField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
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
        public string Mobile {
            get {
                return this.MobileField;
            }
            set {
                if ((object.ReferenceEquals(this.MobileField, value) != true)) {
                    this.MobileField = value;
                    this.RaisePropertyChanged("Mobile");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Property", Namespace="http://schemas.datacontract.org/2004/07/ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Property : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private GUIApplication.LocationServiceReference.Buyer[] BuyersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ConstructionYearField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FloorsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double HouseSizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PropertySizeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int RoomsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
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
        public GUIApplication.LocationServiceReference.Buyer[] Buyers {
            get {
                return this.BuyersField;
            }
            set {
                if ((object.ReferenceEquals(this.BuyersField, value) != true)) {
                    this.BuyersField = value;
                    this.RaisePropertyChanged("Buyers");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LocationServiceReference.ILocationService")]
    public interface ILocationService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationService/InsertLocation", ReplyAction="http://tempuri.org/ILocationService/InsertLocationResponse")]
        void InsertLocation(GUIApplication.LocationServiceReference.Location location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationService/InsertLocation", ReplyAction="http://tempuri.org/ILocationService/InsertLocationResponse")]
        System.Threading.Tasks.Task InsertLocationAsync(GUIApplication.LocationServiceReference.Location location);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationService/GetLocation", ReplyAction="http://tempuri.org/ILocationService/GetLocationResponse")]
        GUIApplication.LocationServiceReference.Location GetLocation(string zipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationService/GetLocation", ReplyAction="http://tempuri.org/ILocationService/GetLocationResponse")]
        System.Threading.Tasks.Task<GUIApplication.LocationServiceReference.Location> GetLocationAsync(string zipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationService/GetLocationsByCity", ReplyAction="http://tempuri.org/ILocationService/GetLocationsByCityResponse")]
        GUIApplication.LocationServiceReference.Location[] GetLocationsByCity(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationService/GetLocationsByCity", ReplyAction="http://tempuri.org/ILocationService/GetLocationsByCityResponse")]
        System.Threading.Tasks.Task<GUIApplication.LocationServiceReference.Location[]> GetLocationsByCityAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationService/GetAllLocations", ReplyAction="http://tempuri.org/ILocationService/GetAllLocationsResponse")]
        GUIApplication.LocationServiceReference.Location[] GetAllLocations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationService/GetAllLocations", ReplyAction="http://tempuri.org/ILocationService/GetAllLocationsResponse")]
        System.Threading.Tasks.Task<GUIApplication.LocationServiceReference.Location[]> GetAllLocationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationService/UpdateLocation", ReplyAction="http://tempuri.org/ILocationService/UpdateLocationResponse")]
        void UpdateLocation(GUIApplication.LocationServiceReference.Location loc, string zipCode, string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationService/UpdateLocation", ReplyAction="http://tempuri.org/ILocationService/UpdateLocationResponse")]
        System.Threading.Tasks.Task UpdateLocationAsync(GUIApplication.LocationServiceReference.Location loc, string zipCode, string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationService/DeleteLocation", ReplyAction="http://tempuri.org/ILocationService/DeleteLocationResponse")]
        void DeleteLocation(GUIApplication.LocationServiceReference.Location loc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILocationService/DeleteLocation", ReplyAction="http://tempuri.org/ILocationService/DeleteLocationResponse")]
        System.Threading.Tasks.Task DeleteLocationAsync(GUIApplication.LocationServiceReference.Location loc);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILocationServiceChannel : GUIApplication.LocationServiceReference.ILocationService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LocationServiceClient : System.ServiceModel.ClientBase<GUIApplication.LocationServiceReference.ILocationService>, GUIApplication.LocationServiceReference.ILocationService {
        
        public LocationServiceClient() {
        }
        
        public LocationServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LocationServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LocationServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LocationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void InsertLocation(GUIApplication.LocationServiceReference.Location location) {
            base.Channel.InsertLocation(location);
        }
        
        public System.Threading.Tasks.Task InsertLocationAsync(GUIApplication.LocationServiceReference.Location location) {
            return base.Channel.InsertLocationAsync(location);
        }
        
        public GUIApplication.LocationServiceReference.Location GetLocation(string zipCode) {
            return base.Channel.GetLocation(zipCode);
        }
        
        public System.Threading.Tasks.Task<GUIApplication.LocationServiceReference.Location> GetLocationAsync(string zipCode) {
            return base.Channel.GetLocationAsync(zipCode);
        }
        
        public GUIApplication.LocationServiceReference.Location[] GetLocationsByCity(string city) {
            return base.Channel.GetLocationsByCity(city);
        }
        
        public System.Threading.Tasks.Task<GUIApplication.LocationServiceReference.Location[]> GetLocationsByCityAsync(string city) {
            return base.Channel.GetLocationsByCityAsync(city);
        }
        
        public GUIApplication.LocationServiceReference.Location[] GetAllLocations() {
            return base.Channel.GetAllLocations();
        }
        
        public System.Threading.Tasks.Task<GUIApplication.LocationServiceReference.Location[]> GetAllLocationsAsync() {
            return base.Channel.GetAllLocationsAsync();
        }
        
        public void UpdateLocation(GUIApplication.LocationServiceReference.Location loc, string zipCode, string city) {
            base.Channel.UpdateLocation(loc, zipCode, city);
        }
        
        public System.Threading.Tasks.Task UpdateLocationAsync(GUIApplication.LocationServiceReference.Location loc, string zipCode, string city) {
            return base.Channel.UpdateLocationAsync(loc, zipCode, city);
        }
        
        public void DeleteLocation(GUIApplication.LocationServiceReference.Location loc) {
            base.Channel.DeleteLocation(loc);
        }
        
        public System.Threading.Tasks.Task DeleteLocationAsync(GUIApplication.LocationServiceReference.Location loc) {
            return base.Channel.DeleteLocationAsync(loc);
        }
    }
}