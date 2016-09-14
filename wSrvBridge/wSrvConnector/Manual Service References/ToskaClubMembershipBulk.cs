﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wSrvConnector.ToskaServices
{
    //------------------------------------------------------------------------------
    // <auto-generated>
    //     This code was generated by a tool.
    //     Runtime Version:4.0.30319.18052
    //
    //     Changes to this file may cause incorrect behavior and will be lost if
    //     the code is regenerated.
    // </auto-generated>
    //------------------------------------------------------------------------------



    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://extranet.turkcell.com.tr/webServices/toskaWebService", ConfigurationName = "toskaClubMembershipSearchOperationsWsPort")]
    public interface toskaClubMembershipSearchOperationsWsPort
    {

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style = System.ServiceModel.OperationFormatStyle.Rpc, Use = System.ServiceModel.OperationFormatUse.Encoded)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(GenericClubMembershipLog))]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        GenericClubMembershipLog[] clubMembershipSearchBulk(ClubMembershipSearchCriteria clubMembershipSearchCriteria);

        [System.ServiceModel.OperationContractAttribute(Action = "", ReplyAction = "*")]
        [return: System.ServiceModel.MessageParameterAttribute(Name = "result")]
        System.Threading.Tasks.Task<GenericClubMembershipLog[]> clubMembershipSearchBulkAsync(ClubMembershipSearchCriteria clubMembershipSearchCriteria);
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "java:com.turkcell.toska.model")]
    public partial class ClubMembershipSearchCriteria
    {

        private int clubIdField;

        private int clubTypeField;

        private string listField;

        private int listTypeField;

        /// <remarks/>
        public int clubId
        {
            get
            {
                return this.clubIdField;
            }
            set
            {
                this.clubIdField = value;
            }
        }

        /// <remarks/>
        public int clubType
        {
            get
            {
                return this.clubTypeField;
            }
            set
            {
                this.clubTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string list
        {
            get
            {
                return this.listField;
            }
            set
            {
                this.listField = value;
            }
        }

        /// <remarks/>
        public int listType
        {
            get
            {
                return this.listTypeField;
            }
            set
            {
                this.listTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace = "java:com.turkcell.toska.model")]
    public partial class GenericClubMembershipLog
    {

        private string addApproveByField;

        private System.Nullable<System.DateTime> addApproveDateField;

        private string addRequestByField;

        private System.Nullable<System.DateTime> addRequestDateField;

        private string altKlupField;

        private int channelField;

        private string clubNameField;

        private int co_idField;

        private string cofferIdField;

        private int customerIdField;

        private string dropApproveByField;

        private System.Nullable<System.DateTime> dropApproveDateField;

        private System.Nullable<System.DateTime> dropDateScheduledField;

        private string dropRequestByField;

        private System.Nullable<System.DateTime> dropRequestDateField;

        private string explanationField;

        private System.Nullable<System.DateTime> logDateField;

        private int membershipAddReasonField;

        private System.Nullable<System.DateTime> membershipDropDateField;

        private int membershipDropReasonField;

        private System.Nullable<System.DateTime> membershipExpireDateField;

        private long membershipIdField;

        private long membershipLogIdField;

        private int membershipRankField;

        private string membershipRankNameField;

        private string membershipReasonDefField;

        private System.Nullable<System.DateTime> membershipStartDateField;

        private int membershipStatusField;

        private string msisdnField;

        private int nclubField;

        private long ncstField;

        private long nprdField;

        private int privilageStatusField;

        private string rankChangedByField;

        private System.Nullable<System.DateTime> rankEndDateField;

        private System.Nullable<System.DateTime> rankStartDateField;

        private string referenceMsisdnField;

        private int userofProductField;

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string addApproveBy
        {
            get
            {
                return this.addApproveByField;
            }
            set
            {
                this.addApproveByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> addApproveDate
        {
            get
            {
                return this.addApproveDateField;
            }
            set
            {
                this.addApproveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string addRequestBy
        {
            get
            {
                return this.addRequestByField;
            }
            set
            {
                this.addRequestByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> addRequestDate
        {
            get
            {
                return this.addRequestDateField;
            }
            set
            {
                this.addRequestDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string altKlup
        {
            get
            {
                return this.altKlupField;
            }
            set
            {
                this.altKlupField = value;
            }
        }

        /// <remarks/>
        public int channel
        {
            get
            {
                return this.channelField;
            }
            set
            {
                this.channelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string clubName
        {
            get
            {
                return this.clubNameField;
            }
            set
            {
                this.clubNameField = value;
            }
        }

        /// <remarks/>
        public int co_id
        {
            get
            {
                return this.co_idField;
            }
            set
            {
                this.co_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string cofferId
        {
            get
            {
                return this.cofferIdField;
            }
            set
            {
                this.cofferIdField = value;
            }
        }

        /// <remarks/>
        public int customerId
        {
            get
            {
                return this.customerIdField;
            }
            set
            {
                this.customerIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string dropApproveBy
        {
            get
            {
                return this.dropApproveByField;
            }
            set
            {
                this.dropApproveByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> dropApproveDate
        {
            get
            {
                return this.dropApproveDateField;
            }
            set
            {
                this.dropApproveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> dropDateScheduled
        {
            get
            {
                return this.dropDateScheduledField;
            }
            set
            {
                this.dropDateScheduledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string dropRequestBy
        {
            get
            {
                return this.dropRequestByField;
            }
            set
            {
                this.dropRequestByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> dropRequestDate
        {
            get
            {
                return this.dropRequestDateField;
            }
            set
            {
                this.dropRequestDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string explanation
        {
            get
            {
                return this.explanationField;
            }
            set
            {
                this.explanationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> logDate
        {
            get
            {
                return this.logDateField;
            }
            set
            {
                this.logDateField = value;
            }
        }

        /// <remarks/>
        public int membershipAddReason
        {
            get
            {
                return this.membershipAddReasonField;
            }
            set
            {
                this.membershipAddReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> membershipDropDate
        {
            get
            {
                return this.membershipDropDateField;
            }
            set
            {
                this.membershipDropDateField = value;
            }
        }

        /// <remarks/>
        public int membershipDropReason
        {
            get
            {
                return this.membershipDropReasonField;
            }
            set
            {
                this.membershipDropReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> membershipExpireDate
        {
            get
            {
                return this.membershipExpireDateField;
            }
            set
            {
                this.membershipExpireDateField = value;
            }
        }

        /// <remarks/>
        public long membershipId
        {
            get
            {
                return this.membershipIdField;
            }
            set
            {
                this.membershipIdField = value;
            }
        }

        /// <remarks/>
        public long membershipLogId
        {
            get
            {
                return this.membershipLogIdField;
            }
            set
            {
                this.membershipLogIdField = value;
            }
        }

        /// <remarks/>
        public int membershipRank
        {
            get
            {
                return this.membershipRankField;
            }
            set
            {
                this.membershipRankField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string membershipRankName
        {
            get
            {
                return this.membershipRankNameField;
            }
            set
            {
                this.membershipRankNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string membershipReasonDef
        {
            get
            {
                return this.membershipReasonDefField;
            }
            set
            {
                this.membershipReasonDefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> membershipStartDate
        {
            get
            {
                return this.membershipStartDateField;
            }
            set
            {
                this.membershipStartDateField = value;
            }
        }

        /// <remarks/>
        public int membershipStatus
        {
            get
            {
                return this.membershipStatusField;
            }
            set
            {
                this.membershipStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string msisdn
        {
            get
            {
                return this.msisdnField;
            }
            set
            {
                this.msisdnField = value;
            }
        }

        /// <remarks/>
        public int nclub
        {
            get
            {
                return this.nclubField;
            }
            set
            {
                this.nclubField = value;
            }
        }

        /// <remarks/>
        public long ncst
        {
            get
            {
                return this.ncstField;
            }
            set
            {
                this.ncstField = value;
            }
        }

        /// <remarks/>
        public long nprd
        {
            get
            {
                return this.nprdField;
            }
            set
            {
                this.nprdField = value;
            }
        }

        /// <remarks/>
        public int privilageStatus
        {
            get
            {
                return this.privilageStatusField;
            }
            set
            {
                this.privilageStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string rankChangedBy
        {
            get
            {
                return this.rankChangedByField;
            }
            set
            {
                this.rankChangedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> rankEndDate
        {
            get
            {
                return this.rankEndDateField;
            }
            set
            {
                this.rankEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> rankStartDate
        {
            get
            {
                return this.rankStartDateField;
            }
            set
            {
                this.rankStartDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable = true)]
        public string referenceMsisdn
        {
            get
            {
                return this.referenceMsisdnField;
            }
            set
            {
                this.referenceMsisdnField = value;
            }
        }

        /// <remarks/>
        public int userofProduct
        {
            get
            {
                return this.userofProductField;
            }
            set
            {
                this.userofProductField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface toskaClubMembershipSearchOperationsWsPortChannel : toskaClubMembershipSearchOperationsWsPort, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class toskaClubMembershipSearchOperationsWsPortClient : System.ServiceModel.ClientBase<toskaClubMembershipSearchOperationsWsPort>, toskaClubMembershipSearchOperationsWsPort
    {

        public toskaClubMembershipSearchOperationsWsPortClient()
        {
        }

        public toskaClubMembershipSearchOperationsWsPortClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public toskaClubMembershipSearchOperationsWsPortClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public toskaClubMembershipSearchOperationsWsPortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public toskaClubMembershipSearchOperationsWsPortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public GenericClubMembershipLog[] clubMembershipSearchBulk(ClubMembershipSearchCriteria clubMembershipSearchCriteria)
        {
            return base.Channel.clubMembershipSearchBulk(clubMembershipSearchCriteria);
        }

        public System.Threading.Tasks.Task<GenericClubMembershipLog[]> clubMembershipSearchBulkAsync(ClubMembershipSearchCriteria clubMembershipSearchCriteria)
        {
            return base.Channel.clubMembershipSearchBulkAsync(clubMembershipSearchCriteria);
        }
    }

}