﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace iOSWebService.com.cdyne.ws {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="DelayedStockQuoteSoap", Namespace="http://ws.cdyne.com/")]
    public partial class DelayedStockQuote : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetQuoteOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetQuickQuoteOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetQuoteDataSetOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public DelayedStockQuote() {
            this.Url = "http://ws.cdyne.com/delayedstockquote/delayedstockquote.asmx";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetQuoteCompletedEventHandler GetQuoteCompleted;
        
        /// <remarks/>
        public event GetQuickQuoteCompletedEventHandler GetQuickQuoteCompleted;
        
        /// <remarks/>
        public event GetQuoteDataSetCompletedEventHandler GetQuoteDataSetCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ws.cdyne.com/GetQuote", RequestNamespace="http://ws.cdyne.com/", ResponseNamespace="http://ws.cdyne.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public QuoteData GetQuote(string StockSymbol, string LicenseKey) {
            object[] results = this.Invoke("GetQuote", new object[] {
                        StockSymbol,
                        LicenseKey});
            return ((QuoteData)(results[0]));
        }
        
        /// <remarks/>
        public void GetQuoteAsync(string StockSymbol, string LicenseKey) {
            this.GetQuoteAsync(StockSymbol, LicenseKey, null);
        }
        
        /// <remarks/>
        public void GetQuoteAsync(string StockSymbol, string LicenseKey, object userState) {
            if ((this.GetQuoteOperationCompleted == null)) {
                this.GetQuoteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetQuoteOperationCompleted);
            }
            this.InvokeAsync("GetQuote", new object[] {
                        StockSymbol,
                        LicenseKey}, this.GetQuoteOperationCompleted, userState);
        }
        
        private void OnGetQuoteOperationCompleted(object arg) {
            if ((this.GetQuoteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetQuoteCompleted(this, new GetQuoteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ws.cdyne.com/GetQuickQuote", RequestNamespace="http://ws.cdyne.com/", ResponseNamespace="http://ws.cdyne.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public decimal GetQuickQuote(string StockSymbol, string LicenseKey) {
            object[] results = this.Invoke("GetQuickQuote", new object[] {
                        StockSymbol,
                        LicenseKey});
            return ((decimal)(results[0]));
        }
        
        /// <remarks/>
        public void GetQuickQuoteAsync(string StockSymbol, string LicenseKey) {
            this.GetQuickQuoteAsync(StockSymbol, LicenseKey, null);
        }
        
        /// <remarks/>
        public void GetQuickQuoteAsync(string StockSymbol, string LicenseKey, object userState) {
            if ((this.GetQuickQuoteOperationCompleted == null)) {
                this.GetQuickQuoteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetQuickQuoteOperationCompleted);
            }
            this.InvokeAsync("GetQuickQuote", new object[] {
                        StockSymbol,
                        LicenseKey}, this.GetQuickQuoteOperationCompleted, userState);
        }
        
        private void OnGetQuickQuoteOperationCompleted(object arg) {
            if ((this.GetQuickQuoteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetQuickQuoteCompleted(this, new GetQuickQuoteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://ws.cdyne.com/GetQuoteDataSet", RequestNamespace="http://ws.cdyne.com/", ResponseNamespace="http://ws.cdyne.com/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetQuoteDataSet(string StockSymbols, string LicenseKey) {
            object[] results = this.Invoke("GetQuoteDataSet", new object[] {
                        StockSymbols,
                        LicenseKey});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetQuoteDataSetAsync(string StockSymbols, string LicenseKey) {
            this.GetQuoteDataSetAsync(StockSymbols, LicenseKey, null);
        }
        
        /// <remarks/>
        public void GetQuoteDataSetAsync(string StockSymbols, string LicenseKey, object userState) {
            if ((this.GetQuoteDataSetOperationCompleted == null)) {
                this.GetQuoteDataSetOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetQuoteDataSetOperationCompleted);
            }
            this.InvokeAsync("GetQuoteDataSet", new object[] {
                        StockSymbols,
                        LicenseKey}, this.GetQuoteDataSetOperationCompleted, userState);
        }
        
        private void OnGetQuoteDataSetOperationCompleted(object arg) {
            if ((this.GetQuoteDataSetCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetQuoteDataSetCompleted(this, new GetQuoteDataSetCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2046.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.cdyne.com/")]
    public partial class QuoteData {
        
        private string stockSymbolField;
        
        private decimal lastTradeAmountField;
        
        private System.DateTime lastTradeDateTimeField;
        
        private decimal stockChangeField;
        
        private decimal openAmountField;
        
        private decimal dayHighField;
        
        private decimal dayLowField;
        
        private int stockVolumeField;
        
        private decimal prevClsField;
        
        private string changePercentField;
        
        private string fiftyTwoWeekRangeField;
        
        private decimal earnPerShareField;
        
        private decimal peField;
        
        private string companyNameField;
        
        private bool quoteErrorField;
        
        /// <remarks/>
        public string StockSymbol {
            get {
                return this.stockSymbolField;
            }
            set {
                this.stockSymbolField = value;
            }
        }
        
        /// <remarks/>
        public decimal LastTradeAmount {
            get {
                return this.lastTradeAmountField;
            }
            set {
                this.lastTradeAmountField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime LastTradeDateTime {
            get {
                return this.lastTradeDateTimeField;
            }
            set {
                this.lastTradeDateTimeField = value;
            }
        }
        
        /// <remarks/>
        public decimal StockChange {
            get {
                return this.stockChangeField;
            }
            set {
                this.stockChangeField = value;
            }
        }
        
        /// <remarks/>
        public decimal OpenAmount {
            get {
                return this.openAmountField;
            }
            set {
                this.openAmountField = value;
            }
        }
        
        /// <remarks/>
        public decimal DayHigh {
            get {
                return this.dayHighField;
            }
            set {
                this.dayHighField = value;
            }
        }
        
        /// <remarks/>
        public decimal DayLow {
            get {
                return this.dayLowField;
            }
            set {
                this.dayLowField = value;
            }
        }
        
        /// <remarks/>
        public int StockVolume {
            get {
                return this.stockVolumeField;
            }
            set {
                this.stockVolumeField = value;
            }
        }
        
        /// <remarks/>
        public decimal PrevCls {
            get {
                return this.prevClsField;
            }
            set {
                this.prevClsField = value;
            }
        }
        
        /// <remarks/>
        public string ChangePercent {
            get {
                return this.changePercentField;
            }
            set {
                this.changePercentField = value;
            }
        }
        
        /// <remarks/>
        public string FiftyTwoWeekRange {
            get {
                return this.fiftyTwoWeekRangeField;
            }
            set {
                this.fiftyTwoWeekRangeField = value;
            }
        }
        
        /// <remarks/>
        public decimal EarnPerShare {
            get {
                return this.earnPerShareField;
            }
            set {
                this.earnPerShareField = value;
            }
        }
        
        /// <remarks/>
        public decimal PE {
            get {
                return this.peField;
            }
            set {
                this.peField = value;
            }
        }
        
        /// <remarks/>
        public string CompanyName {
            get {
                return this.companyNameField;
            }
            set {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        public bool QuoteError {
            get {
                return this.quoteErrorField;
            }
            set {
                this.quoteErrorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetQuoteCompletedEventHandler(object sender, GetQuoteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetQuoteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetQuoteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public QuoteData Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((QuoteData)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetQuickQuoteCompletedEventHandler(object sender, GetQuickQuoteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetQuickQuoteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetQuickQuoteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public decimal Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((decimal)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void GetQuoteDataSetCompletedEventHandler(object sender, GetQuoteDataSetCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetQuoteDataSetCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetQuoteDataSetCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591