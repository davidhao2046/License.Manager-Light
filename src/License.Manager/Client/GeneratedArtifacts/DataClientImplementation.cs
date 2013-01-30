﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication.Implementation
{
    
    #region Product
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Product :
        global::LightSwitchApplication.Product.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        partial void OnNameChanged()
        {
            this.___OnPropertyChanged("Name");
        }
        
        partial void OnDescriptionChanged()
        {
            this.___OnPropertyChanged("Description");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Product.DetailsClass.IImplementation.ProductFeatures
        {
            get
            {
                return this.ProductFeatures;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.ProductFeature> __ProductFeatures
        {
            get
            {
                if (this.___ProductFeatures == null)
                {
                    this.___ProductFeatures = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.ProductFeature>(
                        this,
                        "ProductFeatures",
                        () => this._ProductFeatures,
                        e => global::System.Object.Equals(e.ProductFeature_Product, this.Id));
                }
                return this.___ProductFeatures;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.ProductFeature> ___ProductFeatures;
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Product.DetailsClass.IImplementation.Licenses
        {
            get
            {
                return this.Licenses;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.License> __Licenses
        {
            get
            {
                if (this.___Licenses == null)
                {
                    this.___Licenses = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.License>(
                        this,
                        "Licenses",
                        () => this._Licenses,
                        e => global::System.Object.Equals(e.License_Product, this.Id));
                }
                return this.___Licenses;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.License> ___Licenses;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.Product.DetailsClass.IImplementation.KeyPair
        {
            get
            {
                return this.KeyPair;
            }
            set
            {
                this.KeyPair = (global::LightSwitchApplication.Implementation.KeyPair)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.KeyPair> __KeyPair
        {
            get
            {
                if (this.___KeyPair == null)
                {
                    this.___KeyPair = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.KeyPair>(
                        this,
                        "KeyPair",
                        new string[] { "Id" },
                        e => global::System.Object.Equals(e.Id, this.Id),
                        () => this._KeyPair,
                        e => this._KeyPair = e);
                }
                return this.___KeyPair;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.KeyPair> ___KeyPair;
        
    }
    #endregion
    
    #region ProductFeature
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class ProductFeature :
        global::LightSwitchApplication.ProductFeature.DetailsClass.IImplementation
    {
        partial void OnProductFeature_ProductChanged()
        {
            this.___OnPropertyChanged("ProductFeature_Product");
            this.___OnPropertyChanged("Product");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        partial void OnNameChanged()
        {
            this.___OnPropertyChanged("Name");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.ProductFeature.DetailsClass.IImplementation.Product
        {
            get
            {
                return this.Product;
            }
            set
            {
                this.Product = (global::LightSwitchApplication.Implementation.Product)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Product> __Product
        {
            get
            {
                if (this.___Product == null)
                {
                    this.___Product = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Product>(
                        this,
                        "Product",
                        new string[] { "ProductFeature_Product" },
                        e => global::System.Object.Equals(e.Id, this.ProductFeature_Product),
                        () => this._Product,
                        e => this._Product = e);
                }
                return this.___Product;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Product> ___Product;
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.ProductFeature.DetailsClass.IImplementation.LicenseProductFeatures
        {
            get
            {
                return this.LicenseProductFeatures;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LicenseProductFeature> __LicenseProductFeatures
        {
            get
            {
                if (this.___LicenseProductFeatures == null)
                {
                    this.___LicenseProductFeatures = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LicenseProductFeature>(
                        this,
                        "LicenseProductFeatures",
                        () => this._LicenseProductFeatures,
                        e => global::System.Object.Equals(e.LicenseProductFeature_ProductFeature, this.Id));
                }
                return this.___LicenseProductFeatures;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LicenseProductFeature> ___LicenseProductFeatures;
        
    }
    #endregion
    
    #region Customer
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class Customer :
        global::LightSwitchApplication.Customer.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        partial void OnNameChanged()
        {
            this.___OnPropertyChanged("Name");
        }
        
        partial void OnCompanyChanged()
        {
            this.___OnPropertyChanged("Company");
        }
        
        partial void OnEMailChanged()
        {
            this.___OnPropertyChanged("EMail");
        }
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.Customer.DetailsClass.IImplementation.Licenses
        {
            get
            {
                return this.Licenses;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.License> __Licenses
        {
            get
            {
                if (this.___Licenses == null)
                {
                    this.___Licenses = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.License>(
                        this,
                        "Licenses",
                        () => this._Licenses,
                        e => global::System.Object.Equals(e.License_Customer, this.Id));
                }
                return this.___Licenses;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.License> ___Licenses;
        
    }
    #endregion
    
    #region License
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class License :
        global::LightSwitchApplication.License.DetailsClass.IImplementation
    {
        partial void OnLicense_ProductChanged()
        {
            this.___OnPropertyChanged("License_Product");
            this.___OnPropertyChanged("Product");
        }
        
        partial void OnLicense_CustomerChanged()
        {
            this.___OnPropertyChanged("License_Customer");
            this.___OnPropertyChanged("Customer");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        partial void OnLicenseIdChanged()
        {
            this.___OnPropertyChanged("LicenseId");
        }
        
        partial void OnTypeChanged()
        {
            this.___OnPropertyChanged("Type");
        }
        
        partial void OnQuantityChanged()
        {
            this.___OnPropertyChanged("Quantity");
        }
        
        partial void OnExpirationChanged()
        {
            this.___OnPropertyChanged("Expiration");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.License.DetailsClass.IImplementation.Product
        {
            get
            {
                return this.Product;
            }
            set
            {
                this.Product = (global::LightSwitchApplication.Implementation.Product)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Product> __Product
        {
            get
            {
                if (this.___Product == null)
                {
                    this.___Product = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Product>(
                        this,
                        "Product",
                        new string[] { "License_Product" },
                        e => global::System.Object.Equals(e.Id, this.License_Product),
                        () => this._Product,
                        e => this._Product = e);
                }
                return this.___Product;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Product> ___Product;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.License.DetailsClass.IImplementation.Customer
        {
            get
            {
                return this.Customer;
            }
            set
            {
                this.Customer = (global::LightSwitchApplication.Implementation.Customer)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Customer> __Customer
        {
            get
            {
                if (this.___Customer == null)
                {
                    this.___Customer = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Customer>(
                        this,
                        "Customer",
                        new string[] { "License_Customer" },
                        e => global::System.Object.Equals(e.Id, this.License_Customer),
                        () => this._Customer,
                        e => this._Customer = e);
                }
                return this.___Customer;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Customer> ___Customer;
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.License.DetailsClass.IImplementation.LicenseProductFeatures
        {
            get
            {
                return this.LicenseProductFeatures;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LicenseProductFeature> __LicenseProductFeatures
        {
            get
            {
                if (this.___LicenseProductFeatures == null)
                {
                    this.___LicenseProductFeatures = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LicenseProductFeature>(
                        this,
                        "LicenseProductFeatures",
                        () => this._LicenseProductFeatures,
                        e => global::System.Object.Equals(e.LicenseProductFeature_License, this.Id));
                }
                return this.___LicenseProductFeatures;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LicenseProductFeature> ___LicenseProductFeatures;
        
        global::System.Collections.IEnumerable global::LightSwitchApplication.License.DetailsClass.IImplementation.LicenseAdditionalAttributes
        {
            get
            {
                return this.LicenseAdditionalAttributes;
            }
        }
        
        internal global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LicenseAdditionalAttribute> __LicenseAdditionalAttributes
        {
            get
            {
                if (this.___LicenseAdditionalAttributes == null)
                {
                    this.___LicenseAdditionalAttributes = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LicenseAdditionalAttribute>(
                        this,
                        "LicenseAdditionalAttributes",
                        () => this._LicenseAdditionalAttributes,
                        e => global::System.Object.Equals(e.LicenseAdditionalAttribute_License, this.Id));
                }
                return this.___LicenseAdditionalAttributes;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRefCollection<global::LightSwitchApplication.Implementation.LicenseAdditionalAttribute> ___LicenseAdditionalAttributes;
        
    }
    #endregion
    
    #region LicenseProductFeature
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class LicenseProductFeature :
        global::LightSwitchApplication.LicenseProductFeature.DetailsClass.IImplementation
    {
        partial void OnLicenseProductFeature_LicenseChanged()
        {
            this.___OnPropertyChanged("LicenseProductFeature_License");
            this.___OnPropertyChanged("License");
        }
        
        partial void OnLicenseProductFeature_ProductFeatureChanged()
        {
            this.___OnPropertyChanged("LicenseProductFeature_ProductFeature");
            this.___OnPropertyChanged("ProductFeature");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        partial void OnValueChanged()
        {
            this.___OnPropertyChanged("Value");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.LicenseProductFeature.DetailsClass.IImplementation.License
        {
            get
            {
                return this.License;
            }
            set
            {
                this.License = (global::LightSwitchApplication.Implementation.License)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.License> __License
        {
            get
            {
                if (this.___License == null)
                {
                    this.___License = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.License>(
                        this,
                        "License",
                        new string[] { "LicenseProductFeature_License" },
                        e => global::System.Object.Equals(e.Id, this.LicenseProductFeature_License),
                        () => this._License,
                        e => this._License = e);
                }
                return this.___License;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.License> ___License;
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.LicenseProductFeature.DetailsClass.IImplementation.ProductFeature
        {
            get
            {
                return this.ProductFeature;
            }
            set
            {
                this.ProductFeature = (global::LightSwitchApplication.Implementation.ProductFeature)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.ProductFeature> __ProductFeature
        {
            get
            {
                if (this.___ProductFeature == null)
                {
                    this.___ProductFeature = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.ProductFeature>(
                        this,
                        "ProductFeature",
                        new string[] { "LicenseProductFeature_ProductFeature" },
                        e => global::System.Object.Equals(e.Id, this.LicenseProductFeature_ProductFeature),
                        () => this._ProductFeature,
                        e => this._ProductFeature = e);
                }
                return this.___ProductFeature;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.ProductFeature> ___ProductFeature;
        
    }
    #endregion
    
    #region LicenseAdditionalAttribute
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class LicenseAdditionalAttribute :
        global::LightSwitchApplication.LicenseAdditionalAttribute.DetailsClass.IImplementation
    {
        partial void OnLicenseAdditionalAttribute_LicenseChanged()
        {
            this.___OnPropertyChanged("LicenseAdditionalAttribute_License");
            this.___OnPropertyChanged("License");
        }
        
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        partial void OnNameChanged()
        {
            this.___OnPropertyChanged("Name");
        }
        
        partial void OnValueChanged()
        {
            this.___OnPropertyChanged("Value");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.LicenseAdditionalAttribute.DetailsClass.IImplementation.License
        {
            get
            {
                return this.License;
            }
            set
            {
                this.License = (global::LightSwitchApplication.Implementation.License)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.License> __License
        {
            get
            {
                if (this.___License == null)
                {
                    this.___License = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.License>(
                        this,
                        "License",
                        new string[] { "LicenseAdditionalAttribute_License" },
                        e => global::System.Object.Equals(e.Id, this.LicenseAdditionalAttribute_License),
                        () => this._License,
                        e => this._License = e);
                }
                return this.___License;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.License> ___License;
        
    }
    #endregion
    
    #region KeyPair
    [global::System.Runtime.Serialization.DataContract(Namespace = "http://schemas.datacontract.org/2004/07/ApplicationData.Implementation")]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class KeyPair :
        global::LightSwitchApplication.KeyPair.DetailsClass.IImplementation
    {
        partial void OnIdChanged()
        {
            this.___OnPropertyChanged("Id");
            this.___OnPropertyChanged("Product");
        }
        
        partial void OnRowVersionChanged()
        {
            this.___OnPropertyChanged("RowVersion");
        }
        
        global::Microsoft.LightSwitch.Internal.IEntityImplementation global::LightSwitchApplication.KeyPair.DetailsClass.IImplementation.Product
        {
            get
            {
                return this.Product;
            }
            set
            {
                this.Product = (global::LightSwitchApplication.Implementation.Product)value;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Product> __Product
        {
            get
            {
                if (this.___Product == null)
                {
                    this.___Product = new global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Product>(
                        this,
                        "Product",
                        new string[] { "Id" },
                        e => global::System.Object.Equals(e.Id, this.Id),
                        () => this._Product,
                        e => this._Product = e);
                }
                return this.___Product;
            }
        }
        
        private global::Microsoft.LightSwitch.ClientGenerated.Implementation.EntityRef<global::LightSwitchApplication.Implementation.Product> ___Product;
        
    }
    #endregion
    
    #region ApplicationDataObjectContext
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public partial class ApplicationDataObjectContext
    {
        protected override global::Microsoft.LightSwitch.Internal.IEntityImplementation CreateEntityImplementation<T>()
        {
            if (typeof(T) == typeof(global::LightSwitchApplication.Product))
            {
                return new global::LightSwitchApplication.Implementation.Product();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.ProductFeature))
            {
                return new global::LightSwitchApplication.Implementation.ProductFeature();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.Customer))
            {
                return new global::LightSwitchApplication.Implementation.Customer();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.License))
            {
                return new global::LightSwitchApplication.Implementation.License();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.LicenseProductFeature))
            {
                return new global::LightSwitchApplication.Implementation.LicenseProductFeature();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.LicenseAdditionalAttribute))
            {
                return new global::LightSwitchApplication.Implementation.LicenseAdditionalAttribute();
            }
            if (typeof(T) == typeof(global::LightSwitchApplication.KeyPair))
            {
                return new global::LightSwitchApplication.Implementation.KeyPair();
            }
            return null;
        }
    }
    #endregion
    
    #region DataServiceImplementationFactory
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.IDataServiceFactory))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class DataServiceFactory :
        global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceFactory
    {
    
        protected override global::Microsoft.LightSwitch.IDataService CreateDataService(global::System.Type dataServiceType)
        {
            if (dataServiceType == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.ApplicationData();
            }
            return base.CreateDataService(dataServiceType);
        }
    
        protected override global::Microsoft.LightSwitch.Internal.IDataServiceImplementation CreateDataServiceImplementation<TDataService>(TDataService dataService)
        {
            if (typeof(TDataService) == typeof(global::LightSwitchApplication.ApplicationData))
            {
                return new global::LightSwitchApplication.Implementation.ApplicationDataObjectContext(global::Microsoft.LightSwitch.ClientGenerated.Implementation.DataServiceContext.CreateServiceUri("../ApplicationData.svc"));
            }
            return base.CreateDataServiceImplementation(dataService);
        }
    }
    #endregion
    
    [global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
    [global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.LightSwitch.Internal.ITypeMappingProvider))]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class __TypeMapping
        : global::Microsoft.LightSwitch.Internal.ITypeMappingProvider
    {
        global::System.Type global::Microsoft.LightSwitch.Internal.ITypeMappingProvider.GetImplementationType(global::System.Type definitionType)
        {
            if (typeof(global::LightSwitchApplication.Product) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Product);
            }
            if (typeof(global::LightSwitchApplication.ProductFeature) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.ProductFeature);
            }
            if (typeof(global::LightSwitchApplication.Customer) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.Customer);
            }
            if (typeof(global::LightSwitchApplication.License) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.License);
            }
            if (typeof(global::LightSwitchApplication.LicenseProductFeature) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.LicenseProductFeature);
            }
            if (typeof(global::LightSwitchApplication.LicenseAdditionalAttribute) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.LicenseAdditionalAttribute);
            }
            if (typeof(global::LightSwitchApplication.KeyPair) == definitionType)
            {
                return typeof(global::LightSwitchApplication.Implementation.KeyPair);
            }
            return null;
        }
    }
}
