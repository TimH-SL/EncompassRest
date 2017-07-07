using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Newtonsoft.Json;

namespace EncompassRest.Loans
{
    public sealed partial class Hmda : IClean
    {
        private Value<string> _actionTaken;
        public string ActionTaken { get { return _actionTaken; } set { _actionTaken = value; } }
        private Value<string> _applicationDate;
        public string ApplicationDate { get { return _applicationDate; } set { _applicationDate = value; } }
        private Value<string> _aUS1;
        public string AUS1 { get { return _aUS1; } set { _aUS1 = value; } }
        private Value<string> _aUS2;
        public string AUS2 { get { return _aUS2; } set { _aUS2 = value; } }
        private Value<string> _aUS3;
        public string AUS3 { get { return _aUS3; } set { _aUS3 = value; } }
        private Value<string> _aUS4;
        public string AUS4 { get { return _aUS4; } set { _aUS4 = value; } }
        private Value<string> _aUS5;
        public string AUS5 { get { return _aUS5; } set { _aUS5 = value; } }
        private Value<string> _aUSRecommendation1;
        public string AUSRecommendation1 { get { return _aUSRecommendation1; } set { _aUSRecommendation1 = value; } }
        private Value<string> _aUSRecommendation2;
        public string AUSRecommendation2 { get { return _aUSRecommendation2; } set { _aUSRecommendation2 = value; } }
        private Value<string> _aUSRecommendation3;
        public string AUSRecommendation3 { get { return _aUSRecommendation3; } set { _aUSRecommendation3 = value; } }
        private Value<string> _aUSRecommendation4;
        public string AUSRecommendation4 { get { return _aUSRecommendation4; } set { _aUSRecommendation4 = value; } }
        private Value<string> _aUSRecommendation5;
        public string AUSRecommendation5 { get { return _aUSRecommendation5; } set { _aUSRecommendation5 = value; } }
        private Value<string> _businessOrCommercialPurpose;
        public string BusinessOrCommercialPurpose { get { return _businessOrCommercialPurpose; } set { _businessOrCommercialPurpose = value; } }
        private Value<string> _censusTrack;
        public string CensusTrack { get { return _censusTrack; } set { _censusTrack = value; } }
        private Value<NA<decimal>?> _cLTV;
        public NA<decimal>? CLTV { get { return _cLTV; } set { _cLTV = value; } }
        private Value<string> _contactEmailAddress;
        public string ContactEmailAddress { get { return _contactEmailAddress; } set { _contactEmailAddress = value; } }
        private Value<string> _contactFaxNumber;
        public string ContactFaxNumber { get { return _contactFaxNumber; } set { _contactFaxNumber = value; } }
        private Value<string> _contactName;
        public string ContactName { get { return _contactName; } set { _contactName = value; } }
        private Value<string> _contactOfficeCity;
        public string ContactOfficeCity { get { return _contactOfficeCity; } set { _contactOfficeCity = value; } }
        private Value<string> _contactOfficeState;
        public string ContactOfficeState { get { return _contactOfficeState; } set { _contactOfficeState = value; } }
        private Value<string> _contactOfficeStreetAddress;
        public string ContactOfficeStreetAddress { get { return _contactOfficeStreetAddress; } set { _contactOfficeStreetAddress = value; } }
        private Value<string> _contactOfficeZIPCode;
        public string ContactOfficeZIPCode { get { return _contactOfficeZIPCode; } set { _contactOfficeZIPCode = value; } }
        private Value<string> _contactPhoneNumber;
        public string ContactPhoneNumber { get { return _contactPhoneNumber; } set { _contactPhoneNumber = value; } }
        private Value<string> _countyCode;
        public string CountyCode { get { return _countyCode; } set { _countyCode = value; } }
        private Value<NA<decimal>?> _debtToIncomeRatio;
        public NA<decimal>? DebtToIncomeRatio { get { return _debtToIncomeRatio; } set { _debtToIncomeRatio = value; } }
        private Value<string> _denialReason1;
        public string DenialReason1 { get { return _denialReason1; } set { _denialReason1 = value; } }
        private Value<string> _denialReason2;
        public string DenialReason2 { get { return _denialReason2; } set { _denialReason2 = value; } }
        private Value<string> _denialReason3;
        public string DenialReason3 { get { return _denialReason3; } set { _denialReason3 = value; } }
        private Value<string> _denialReason4;
        public string DenialReason4 { get { return _denialReason4; } set { _denialReason4 = value; } }
        private Value<NA<decimal>?> _discountPoints;
        public NA<decimal>? DiscountPoints { get { return _discountPoints; } set { _discountPoints = value; } }
        private Value<bool?> _excludeLoanFromHMDAReportIndicator;
        public bool? ExcludeLoanFromHMDAReportIndicator { get { return _excludeLoanFromHMDAReportIndicator; } set { _excludeLoanFromHMDAReportIndicator = value; } }
        private Value<string> _federalAgency;
        public string FederalAgency { get { return _federalAgency; } set { _federalAgency = value; } }
        private Value<string> _federalTaxpayerIdNumber;
        public string FederalTaxpayerIdNumber { get { return _federalTaxpayerIdNumber; } set { _federalTaxpayerIdNumber = value; } }
        private Value<string> _financialInstitutionName;
        public string FinancialInstitutionName { get { return _financialInstitutionName; } set { _financialInstitutionName = value; } }
        private Value<string> _hmdaPropertyAddress;
        public string HmdaPropertyAddress { get { return _hmdaPropertyAddress; } set { _hmdaPropertyAddress = value; } }
        private Value<string> _hmdaPropertyCity;
        public string HmdaPropertyCity { get { return _hmdaPropertyCity; } set { _hmdaPropertyCity = value; } }
        private Value<string> _hmdaPropertyState;
        public string HmdaPropertyState { get { return _hmdaPropertyState; } set { _hmdaPropertyState = value; } }
        private Value<string> _hmdaPropertyZipCode;
        public string HmdaPropertyZipCode { get { return _hmdaPropertyZipCode; } set { _hmdaPropertyZipCode = value; } }
        private Value<bool?> _hmdaSyncAddressIndicator;
        public bool? HmdaSyncAddressIndicator { get { return _hmdaSyncAddressIndicator; } set { _hmdaSyncAddressIndicator = value; } }
        private Value<string> _hOEPAStatus;
        public string HOEPAStatus { get { return _hOEPAStatus; } set { _hOEPAStatus = value; } }
        private Value<string> _id;
        public string Id { get { return _id; } set { _id = value; } }
        private Value<NA<decimal>?> _income;
        public NA<decimal>? Income { get { return _income; } set { _income = value; } }
        private Value<string> _initiallyPayableToYourInstitution;
        public string InitiallyPayableToYourInstitution { get { return _initiallyPayableToYourInstitution; } set { _initiallyPayableToYourInstitution = value; } }
        private Value<NA<decimal>?> _interestRate;
        public NA<decimal>? InterestRate { get { return _interestRate; } set { _interestRate = value; } }
        private Value<string> _introRatePeriod;
        public string IntroRatePeriod { get { return _introRatePeriod; } set { _introRatePeriod = value; } }
        private Value<string> _legalEntityIdentifier;
        public string LegalEntityIdentifier { get { return _legalEntityIdentifier; } set { _legalEntityIdentifier = value; } }
        private Value<NA<decimal>?> _lenderCredits;
        public NA<decimal>? LenderCredits { get { return _lenderCredits; } set { _lenderCredits = value; } }
        private Value<string> _lienStatus;
        public string LienStatus { get { return _lienStatus; } set { _lienStatus = value; } }
        private Value<decimal?> _loanAmount;
        public decimal? LoanAmount { get { return _loanAmount; } set { _loanAmount = value; } }
        private Value<string> _loanPurpose;
        public string LoanPurpose { get { return _loanPurpose; } set { _loanPurpose = value; } }
        private Value<string> _loanTerm;
        public string LoanTerm { get { return _loanTerm; } set { _loanTerm = value; } }
        private Value<string> _loanType;
        public string LoanType { get { return _loanType; } set { _loanType = value; } }
        private Value<string> _manufacturedHomeLandPropertyInterest;
        public string ManufacturedHomeLandPropertyInterest { get { return _manufacturedHomeLandPropertyInterest; } set { _manufacturedHomeLandPropertyInterest = value; } }
        private Value<string> _manufacturedSecuredProperyType;
        public string ManufacturedSecuredProperyType { get { return _manufacturedSecuredProperyType; } set { _manufacturedSecuredProperyType = value; } }
        private Value<string> _mSANumber;
        public string MSANumber { get { return _mSANumber; } set { _mSANumber = value; } }
        private Value<string> _multifamilyNoUnits;
        public string MultifamilyNoUnits { get { return _multifamilyNoUnits; } set { _multifamilyNoUnits = value; } }
        private Value<string> _nMLSLoanOriginatorID;
        public string NMLSLoanOriginatorID { get { return _nMLSLoanOriginatorID; } set { _nMLSLoanOriginatorID = value; } }
        private Value<string> _openEndLineOfCredit;
        public string OpenEndLineOfCredit { get { return _openEndLineOfCredit; } set { _openEndLineOfCredit = value; } }
        private Value<string> _originationCharges;
        public string OriginationCharges { get { return _originationCharges; } set { _originationCharges = value; } }
        private Value<string> _otherAUS;
        public string OtherAUS { get { return _otherAUS; } set { _otherAUS = value; } }
        private Value<string> _otherAUSRecommendations;
        public string OtherAUSRecommendations { get { return _otherAUSRecommendations; } set { _otherAUSRecommendations = value; } }
        private Value<string> _otherDenialReason;
        public string OtherDenialReason { get { return _otherDenialReason; } set { _otherDenialReason = value; } }
        private Value<string> _otherNonAmortization;
        public string OtherNonAmortization { get { return _otherNonAmortization; } set { _otherNonAmortization = value; } }
        private Value<string> _parentAddress;
        public string ParentAddress { get { return _parentAddress; } set { _parentAddress = value; } }
        private Value<string> _parentCity;
        public string ParentCity { get { return _parentCity; } set { _parentCity = value; } }
        private Value<string> _parentName;
        public string ParentName { get { return _parentName; } set { _parentName = value; } }
        private Value<string> _parentState;
        public string ParentState { get { return _parentState; } set { _parentState = value; } }
        private Value<string> _parentZip;
        public string ParentZip { get { return _parentZip; } set { _parentZip = value; } }
        private Value<string> _preapprovals;
        public string Preapprovals { get { return _preapprovals; } set { _preapprovals = value; } }
        private Value<string> _prepaymentPenaltyPeriod;
        public string PrepaymentPenaltyPeriod { get { return _prepaymentPenaltyPeriod; } set { _prepaymentPenaltyPeriod = value; } }
        private Value<string> _propertyType;
        public string PropertyType { get { return _propertyType; } set { _propertyType = value; } }
        private Value<NA<decimal>?> _propertyValue;
        public NA<decimal>? PropertyValue { get { return _propertyValue; } set { _propertyValue = value; } }
        private Value<string> _qMStatus;
        public string QMStatus { get { return _qMStatus; } set { _qMStatus = value; } }
        private Value<NA<decimal>?> _rateSpread;
        public NA<decimal>? RateSpread { get { return _rateSpread; } set { _rateSpread = value; } }
        private Value<int?> _reportingYear;
        public int? ReportingYear { get { return _reportingYear; } set { _reportingYear = value; } }
        private Value<bool?> _reportPurposeOfLoanIndicator;
        public bool? ReportPurposeOfLoanIndicator { get { return _reportPurposeOfLoanIndicator; } set { _reportPurposeOfLoanIndicator = value; } }
        private Value<string> _repurchasedActionDate;
        public string RepurchasedActionDate { get { return _repurchasedActionDate; } set { _repurchasedActionDate = value; } }
        private Value<string> _repurchasedActionTaken;
        public string RepurchasedActionTaken { get { return _repurchasedActionTaken; } set { _repurchasedActionTaken = value; } }
        private Value<decimal?> _repurchasedLoanAmount;
        public decimal? RepurchasedLoanAmount { get { return _repurchasedLoanAmount; } set { _repurchasedLoanAmount = value; } }
        private Value<int?> _repurchasedReportingYear;
        public int? RepurchasedReportingYear { get { return _repurchasedReportingYear; } set { _repurchasedReportingYear = value; } }
        private Value<string> _repurchasedTypeOfPurchaser;
        public string RepurchasedTypeOfPurchaser { get { return _repurchasedTypeOfPurchaser; } set { _repurchasedTypeOfPurchaser = value; } }
        private Value<string> _respondentID;
        public string RespondentID { get { return _respondentID; } set { _respondentID = value; } }
        private Value<string> _reverseMortgage;
        public string ReverseMortgage { get { return _reverseMortgage; } set { _reverseMortgage = value; } }
        private Value<string> _stateCode;
        public string StateCode { get { return _stateCode; } set { _stateCode = value; } }
        private Value<string> _submissionOfApplication;
        public string SubmissionOfApplication { get { return _submissionOfApplication; } set { _submissionOfApplication = value; } }
        private Value<string> _totalLoanCosts;
        public string TotalLoanCosts { get { return _totalLoanCosts; } set { _totalLoanCosts = value; } }
        private Value<string> _totalPointsAndFees;
        public string TotalPointsAndFees { get { return _totalPointsAndFees; } set { _totalPointsAndFees = value; } }
        private Value<string> _typeOfPurchaser;
        public string TypeOfPurchaser { get { return _typeOfPurchaser; } set { _typeOfPurchaser = value; } }
        private Value<string> _universalLoanId;
        public string UniversalLoanId { get { return _universalLoanId; } set { _universalLoanId = value; } }
        private int _gettingClean;
        private int _settingClean; 
        internal bool Clean
        {
            get
            {
                if (Interlocked.CompareExchange(ref _gettingClean, 1, 0) != 0) return true;
                var clean = _actionTaken.Clean
                    && _applicationDate.Clean
                    && _aUS1.Clean
                    && _aUS2.Clean
                    && _aUS3.Clean
                    && _aUS4.Clean
                    && _aUS5.Clean
                    && _aUSRecommendation1.Clean
                    && _aUSRecommendation2.Clean
                    && _aUSRecommendation3.Clean
                    && _aUSRecommendation4.Clean
                    && _aUSRecommendation5.Clean
                    && _businessOrCommercialPurpose.Clean
                    && _censusTrack.Clean
                    && _cLTV.Clean
                    && _contactEmailAddress.Clean
                    && _contactFaxNumber.Clean
                    && _contactName.Clean
                    && _contactOfficeCity.Clean
                    && _contactOfficeState.Clean
                    && _contactOfficeStreetAddress.Clean
                    && _contactOfficeZIPCode.Clean
                    && _contactPhoneNumber.Clean
                    && _countyCode.Clean
                    && _debtToIncomeRatio.Clean
                    && _denialReason1.Clean
                    && _denialReason2.Clean
                    && _denialReason3.Clean
                    && _denialReason4.Clean
                    && _discountPoints.Clean
                    && _excludeLoanFromHMDAReportIndicator.Clean
                    && _federalAgency.Clean
                    && _federalTaxpayerIdNumber.Clean
                    && _financialInstitutionName.Clean
                    && _hmdaPropertyAddress.Clean
                    && _hmdaPropertyCity.Clean
                    && _hmdaPropertyState.Clean
                    && _hmdaPropertyZipCode.Clean
                    && _hmdaSyncAddressIndicator.Clean
                    && _hOEPAStatus.Clean
                    && _id.Clean
                    && _income.Clean
                    && _initiallyPayableToYourInstitution.Clean
                    && _interestRate.Clean
                    && _introRatePeriod.Clean
                    && _legalEntityIdentifier.Clean
                    && _lenderCredits.Clean
                    && _lienStatus.Clean
                    && _loanAmount.Clean
                    && _loanPurpose.Clean
                    && _loanTerm.Clean
                    && _loanType.Clean
                    && _manufacturedHomeLandPropertyInterest.Clean
                    && _manufacturedSecuredProperyType.Clean
                    && _mSANumber.Clean
                    && _multifamilyNoUnits.Clean
                    && _nMLSLoanOriginatorID.Clean
                    && _openEndLineOfCredit.Clean
                    && _originationCharges.Clean
                    && _otherAUS.Clean
                    && _otherAUSRecommendations.Clean
                    && _otherDenialReason.Clean
                    && _otherNonAmortization.Clean
                    && _parentAddress.Clean
                    && _parentCity.Clean
                    && _parentName.Clean
                    && _parentState.Clean
                    && _parentZip.Clean
                    && _preapprovals.Clean
                    && _prepaymentPenaltyPeriod.Clean
                    && _propertyType.Clean
                    && _propertyValue.Clean
                    && _qMStatus.Clean
                    && _rateSpread.Clean
                    && _reportingYear.Clean
                    && _reportPurposeOfLoanIndicator.Clean
                    && _repurchasedActionDate.Clean
                    && _repurchasedActionTaken.Clean
                    && _repurchasedLoanAmount.Clean
                    && _repurchasedReportingYear.Clean
                    && _repurchasedTypeOfPurchaser.Clean
                    && _respondentID.Clean
                    && _reverseMortgage.Clean
                    && _stateCode.Clean
                    && _submissionOfApplication.Clean
                    && _totalLoanCosts.Clean
                    && _totalPointsAndFees.Clean
                    && _typeOfPurchaser.Clean
                    && _universalLoanId.Clean;
                _gettingClean = 0;
                return clean;
            }
            set
            {
                if (Interlocked.CompareExchange(ref _settingClean, 1, 0) != 0) return;
                var v0 = _actionTaken; v0.Clean = value; _actionTaken = v0;
                var v1 = _applicationDate; v1.Clean = value; _applicationDate = v1;
                var v2 = _aUS1; v2.Clean = value; _aUS1 = v2;
                var v3 = _aUS2; v3.Clean = value; _aUS2 = v3;
                var v4 = _aUS3; v4.Clean = value; _aUS3 = v4;
                var v5 = _aUS4; v5.Clean = value; _aUS4 = v5;
                var v6 = _aUS5; v6.Clean = value; _aUS5 = v6;
                var v7 = _aUSRecommendation1; v7.Clean = value; _aUSRecommendation1 = v7;
                var v8 = _aUSRecommendation2; v8.Clean = value; _aUSRecommendation2 = v8;
                var v9 = _aUSRecommendation3; v9.Clean = value; _aUSRecommendation3 = v9;
                var v10 = _aUSRecommendation4; v10.Clean = value; _aUSRecommendation4 = v10;
                var v11 = _aUSRecommendation5; v11.Clean = value; _aUSRecommendation5 = v11;
                var v12 = _businessOrCommercialPurpose; v12.Clean = value; _businessOrCommercialPurpose = v12;
                var v13 = _censusTrack; v13.Clean = value; _censusTrack = v13;
                var v14 = _cLTV; v14.Clean = value; _cLTV = v14;
                var v15 = _contactEmailAddress; v15.Clean = value; _contactEmailAddress = v15;
                var v16 = _contactFaxNumber; v16.Clean = value; _contactFaxNumber = v16;
                var v17 = _contactName; v17.Clean = value; _contactName = v17;
                var v18 = _contactOfficeCity; v18.Clean = value; _contactOfficeCity = v18;
                var v19 = _contactOfficeState; v19.Clean = value; _contactOfficeState = v19;
                var v20 = _contactOfficeStreetAddress; v20.Clean = value; _contactOfficeStreetAddress = v20;
                var v21 = _contactOfficeZIPCode; v21.Clean = value; _contactOfficeZIPCode = v21;
                var v22 = _contactPhoneNumber; v22.Clean = value; _contactPhoneNumber = v22;
                var v23 = _countyCode; v23.Clean = value; _countyCode = v23;
                var v24 = _debtToIncomeRatio; v24.Clean = value; _debtToIncomeRatio = v24;
                var v25 = _denialReason1; v25.Clean = value; _denialReason1 = v25;
                var v26 = _denialReason2; v26.Clean = value; _denialReason2 = v26;
                var v27 = _denialReason3; v27.Clean = value; _denialReason3 = v27;
                var v28 = _denialReason4; v28.Clean = value; _denialReason4 = v28;
                var v29 = _discountPoints; v29.Clean = value; _discountPoints = v29;
                var v30 = _excludeLoanFromHMDAReportIndicator; v30.Clean = value; _excludeLoanFromHMDAReportIndicator = v30;
                var v31 = _federalAgency; v31.Clean = value; _federalAgency = v31;
                var v32 = _federalTaxpayerIdNumber; v32.Clean = value; _federalTaxpayerIdNumber = v32;
                var v33 = _financialInstitutionName; v33.Clean = value; _financialInstitutionName = v33;
                var v34 = _hmdaPropertyAddress; v34.Clean = value; _hmdaPropertyAddress = v34;
                var v35 = _hmdaPropertyCity; v35.Clean = value; _hmdaPropertyCity = v35;
                var v36 = _hmdaPropertyState; v36.Clean = value; _hmdaPropertyState = v36;
                var v37 = _hmdaPropertyZipCode; v37.Clean = value; _hmdaPropertyZipCode = v37;
                var v38 = _hmdaSyncAddressIndicator; v38.Clean = value; _hmdaSyncAddressIndicator = v38;
                var v39 = _hOEPAStatus; v39.Clean = value; _hOEPAStatus = v39;
                var v40 = _id; v40.Clean = value; _id = v40;
                var v41 = _income; v41.Clean = value; _income = v41;
                var v42 = _initiallyPayableToYourInstitution; v42.Clean = value; _initiallyPayableToYourInstitution = v42;
                var v43 = _interestRate; v43.Clean = value; _interestRate = v43;
                var v44 = _introRatePeriod; v44.Clean = value; _introRatePeriod = v44;
                var v45 = _legalEntityIdentifier; v45.Clean = value; _legalEntityIdentifier = v45;
                var v46 = _lenderCredits; v46.Clean = value; _lenderCredits = v46;
                var v47 = _lienStatus; v47.Clean = value; _lienStatus = v47;
                var v48 = _loanAmount; v48.Clean = value; _loanAmount = v48;
                var v49 = _loanPurpose; v49.Clean = value; _loanPurpose = v49;
                var v50 = _loanTerm; v50.Clean = value; _loanTerm = v50;
                var v51 = _loanType; v51.Clean = value; _loanType = v51;
                var v52 = _manufacturedHomeLandPropertyInterest; v52.Clean = value; _manufacturedHomeLandPropertyInterest = v52;
                var v53 = _manufacturedSecuredProperyType; v53.Clean = value; _manufacturedSecuredProperyType = v53;
                var v54 = _mSANumber; v54.Clean = value; _mSANumber = v54;
                var v55 = _multifamilyNoUnits; v55.Clean = value; _multifamilyNoUnits = v55;
                var v56 = _nMLSLoanOriginatorID; v56.Clean = value; _nMLSLoanOriginatorID = v56;
                var v57 = _openEndLineOfCredit; v57.Clean = value; _openEndLineOfCredit = v57;
                var v58 = _originationCharges; v58.Clean = value; _originationCharges = v58;
                var v59 = _otherAUS; v59.Clean = value; _otherAUS = v59;
                var v60 = _otherAUSRecommendations; v60.Clean = value; _otherAUSRecommendations = v60;
                var v61 = _otherDenialReason; v61.Clean = value; _otherDenialReason = v61;
                var v62 = _otherNonAmortization; v62.Clean = value; _otherNonAmortization = v62;
                var v63 = _parentAddress; v63.Clean = value; _parentAddress = v63;
                var v64 = _parentCity; v64.Clean = value; _parentCity = v64;
                var v65 = _parentName; v65.Clean = value; _parentName = v65;
                var v66 = _parentState; v66.Clean = value; _parentState = v66;
                var v67 = _parentZip; v67.Clean = value; _parentZip = v67;
                var v68 = _preapprovals; v68.Clean = value; _preapprovals = v68;
                var v69 = _prepaymentPenaltyPeriod; v69.Clean = value; _prepaymentPenaltyPeriod = v69;
                var v70 = _propertyType; v70.Clean = value; _propertyType = v70;
                var v71 = _propertyValue; v71.Clean = value; _propertyValue = v71;
                var v72 = _qMStatus; v72.Clean = value; _qMStatus = v72;
                var v73 = _rateSpread; v73.Clean = value; _rateSpread = v73;
                var v74 = _reportingYear; v74.Clean = value; _reportingYear = v74;
                var v75 = _reportPurposeOfLoanIndicator; v75.Clean = value; _reportPurposeOfLoanIndicator = v75;
                var v76 = _repurchasedActionDate; v76.Clean = value; _repurchasedActionDate = v76;
                var v77 = _repurchasedActionTaken; v77.Clean = value; _repurchasedActionTaken = v77;
                var v78 = _repurchasedLoanAmount; v78.Clean = value; _repurchasedLoanAmount = v78;
                var v79 = _repurchasedReportingYear; v79.Clean = value; _repurchasedReportingYear = v79;
                var v80 = _repurchasedTypeOfPurchaser; v80.Clean = value; _repurchasedTypeOfPurchaser = v80;
                var v81 = _respondentID; v81.Clean = value; _respondentID = v81;
                var v82 = _reverseMortgage; v82.Clean = value; _reverseMortgage = v82;
                var v83 = _stateCode; v83.Clean = value; _stateCode = v83;
                var v84 = _submissionOfApplication; v84.Clean = value; _submissionOfApplication = v84;
                var v85 = _totalLoanCosts; v85.Clean = value; _totalLoanCosts = v85;
                var v86 = _totalPointsAndFees; v86.Clean = value; _totalPointsAndFees = v86;
                var v87 = _typeOfPurchaser; v87.Clean = value; _typeOfPurchaser = v87;
                var v88 = _universalLoanId; v88.Clean = value; _universalLoanId = v88;
                _settingClean = 0;
            }
        }
        bool IClean.Clean { get { return Clean; } set { Clean = value; } }
        [JsonConstructor]
        public Hmda()
        {
            Clean = true;
        }
    }
}