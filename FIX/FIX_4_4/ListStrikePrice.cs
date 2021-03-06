//    Copyright 2006, 2007, 2008 East Tech Incorporated
//
//    This file is part of FIX4NET.
//
//    FIX4NET is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Lesser General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    FIX4NET is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with FIX4NET.  If not, see <http://www.gnu.org/licenses/>.
//
using System;
using System.Collections;
using System.Text;

using FIX = FIX4NET.FIX;

namespace FIX4NET.FIX.FIX_4_4
{
	/// <summary>
	/// Summary description for ListStrikePrice.
	/// </summary>
	public class ListStrikePrice : Message
	{
		public const int TAG_ListID = 66;
		public const int TAG_TotNoStrikes = 422;
		public const int TAG_LastFragment = 893;
		public const int TAG_NoStrikes = 428;
		public const int TAG_Symbol = 55;
		public const int TAG_SymbolSfx = 65;
		public const int TAG_SecurityID = 48;
		public const int TAG_SecurityIDSource = 22;
		public const int TAG_NoSecurityAltID = 454;
		public const int TAG_SecurityAltID = 455;
		public const int TAG_SecurityAltIDSource = 456;
		public const int TAG_Product = 460;
		public const int TAG_CFICode = 461;
		public const int TAG_SecurityType = 167;
		public const int TAG_SecuritySubType = 762;
		public const int TAG_MaturityMonthYear = 200;
		public const int TAG_MaturityDate = 541;
		public const int TAG_CouponPaymentDate = 224;
		public const int TAG_IssueDate = 225;
		public const int TAG_RepoCollateralSecurityType = 239;
		public const int TAG_RepurchaseTerm = 226;
		public const int TAG_RepurchaseRate = 227;
		public const int TAG_Factor = 228;
		public const int TAG_CreditRating = 255;
		public const int TAG_InstrRegistry = 543;
		public const int TAG_CountryOfIssue = 470;
		public const int TAG_StateOrProvinceOfIssue = 471;
		public const int TAG_LocaleOfIssue = 472;
		public const int TAG_RedemptionDate = 240;
		public const int TAG_StrikePrice = 202;
		public const int TAG_StrikeCurrency = 947;
		public const int TAG_OptAttribute = 206;
		public const int TAG_ContractMultiplier = 231;
		public const int TAG_CouponRate = 223;
		public const int TAG_SecurityExchange = 207;
		public const int TAG_Issuer = 106;
		public const int TAG_EncodedIssuerLen = 348;
		public const int TAG_EncodedIssuer = 349;
		public const int TAG_SecurityDesc = 107;
		public const int TAG_EncodedSecurityDescLen = 350;
		public const int TAG_EncodedSecurityDesc = 351;
		public const int TAG_Pool = 691;
		public const int TAG_ContractSettlMonth = 667;
		public const int TAG_CPProgram = 875;
		public const int TAG_CPRegType = 876;
		public const int TAG_NoEvents = 864;
		public const int TAG_EventType = 865;
		public const int TAG_EventDate = 866;
		public const int TAG_EventPx = 867;
		public const int TAG_EventText = 868;
		public const int TAG_DatedDate = 873;
		public const int TAG_InterestAccrualDate = 874;
		public const int TAG_NoUnderlyings = 711;
		public const int TAG_UnderlyingSymbol = 311;
		public const int TAG_UnderlyingSymbolSfx = 312;
		public const int TAG_UnderlyingSecurityID = 309;
		public const int TAG_UnderlyingSecurityIDSource = 305;
		public const int TAG_NoUnderlyingSecurityAltID = 457;
		public const int TAG_UnderlyingSecurityAltID = 458;
		public const int TAG_UnderlyingSecurityAltIDSource = 459;
		public const int TAG_UnderlyingProduct = 462;
		public const int TAG_UnderlyingCFICode = 463;
		public const int TAG_UnderlyingSecurityType = 310;
		public const int TAG_UnderlyingSecuritySubType = 763;
		public const int TAG_UnderlyingMaturityMonthYear = 313;
		public const int TAG_UnderlyingMaturityDate = 542;
		public const int TAG_UnderlyingCouponPaymentDate = 241;
		public const int TAG_UnderlyingIssueDate = 242;
		public const int TAG_UnderlyingRepoCollateralSecurityType = 243;
		public const int TAG_UnderlyingRepurchaseTerm = 244;
		public const int TAG_UnderlyingRepurchaseRate = 245;
		public const int TAG_UnderlyingFactor = 246;
		public const int TAG_UnderlyingCreditRating = 256;
		public const int TAG_UnderlyingInstrRegistry = 595;
		public const int TAG_UnderlyingCountryOfIssue = 592;
		public const int TAG_UnderlyingStateOrProvinceOfIssue = 593;
		public const int TAG_UnderlyingLocaleOfIssue = 594;
		public const int TAG_UnderlyingRedemptionDate = 247;
		public const int TAG_UnderlyingStrikePrice = 316;
		public const int TAG_UnderlyingStrikeCurrency = 941;
		public const int TAG_UnderlyingOptAttribute = 317;
		public const int TAG_UnderlyingContractMultiplier = 436;
		public const int TAG_UnderlyingCouponRate = 435;
		public const int TAG_UnderlyingSecurityExchange = 308;
		public const int TAG_UnderlyingIssuer = 306;
		public const int TAG_EncodedUnderlyingIssuerLen = 362;
		public const int TAG_EncodedUnderlyingIssuer = 363;
		public const int TAG_UnderlyingSecurityDesc = 307;
		public const int TAG_EncodedUnderlyingSecurityDescLen = 364;
		public const int TAG_EncodedUnderlyingSecurityDesc = 365;
		public const int TAG_UnderlyingCPProgram = 877;
		public const int TAG_UnderlyingCPRegType = 878;
		public const int TAG_UnderlyingCurrency = 318;
		public const int TAG_UnderlyingQty = 879;
		public const int TAG_UnderlyingPx = 810;
		public const int TAG_UnderlyingDirtyPrice = 882;
		public const int TAG_UnderlyingEndPrice = 883;
		public const int TAG_UnderlyingStartValue = 884;
		public const int TAG_UnderlyingCurrentValue = 885;
		public const int TAG_UnderlyingEndValue = 886;
		public const int TAG_PrevClosePx = 140;
		public const int TAG_ClOrdID = 11;
		public const int TAG_SecondaryClOrdID = 526;
		public const int TAG_Side = 54;
		public const int TAG_Price = 44;
		public const int TAG_Currency = 15;
		public const int TAG_Text = 58;
		public const int TAG_EncodedTextLen = 354;
		public const int TAG_EncodedText = 355;

		private string _sListID;
		private int _iTotNoStrikes;
		private bool _bLastFragment;
		private int _iNoStrikes;
		private ListStrikePriceStrikeList _listStrike = new ListStrikePriceStrikeList();
		private int _iNoUnderlyings;
		private ListStrikePriceUnderlyingList _listUnderlying = new ListStrikePriceUnderlyingList();

		public ListStrikePrice() : base()
		{
			_sMsgType = Values.MsgType.ListStrikePrice;
		}

		public string ListID
		{
			get { return _sListID; }
			set { _sListID = value; }
		}
		public int TotNoStrikes
		{
			get { return _iTotNoStrikes; }
			set { _iTotNoStrikes = value; }
		}
		public bool LastFragment
		{
			get { return _bLastFragment; }
			set { _bLastFragment = value; }
		}
		public int NoStrikes
		{
			get { return _iNoStrikes; }
			set { _iNoStrikes = value; }
		}
		public ListStrikePriceStrikeList Strike 
		{
			get { return _listStrike; }
		}
		public int NoUnderlyings
		{
			get { return _iNoUnderlyings; }
			set { _iNoUnderlyings = value; }
		}
		public ListStrikePriceUnderlyingList Underlying 
		{
			get { return _listUnderlying; }
		}

		public override object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case TAG_ListID:
						return _sListID;
					case TAG_TotNoStrikes:
						return _iTotNoStrikes;
					case TAG_LastFragment:
						return _bLastFragment;
					case TAG_NoStrikes:
						return _iNoStrikes;
					case TAG_NoUnderlyings:
						return _iNoUnderlyings;
					default:
						return base[iTag];
				}
			}
			set
			{
				switch (iTag)
				{
					case TAG_ListID:
						_sListID = (string)value;
						break;
					case TAG_TotNoStrikes:
						_iTotNoStrikes = (int)value;
						break;
					case TAG_LastFragment:
						_bLastFragment = (bool)value;
						break;
					case TAG_NoStrikes:
						_iNoStrikes = (int)value;
						break;
					case TAG_NoUnderlyings:
						_iNoUnderlyings = (int)value;
						break;
					default:
						base[iTag] = value;
						break;
				}
			}
		}

	}

	public class ListStrikePriceStrike
	{
		private string _sSymbol;
		private string _sSymbolSfx;
		private string _sSecurityID;
		private string _sSecurityIDSource;
		private int _iNoSecurityAltID;
		private ListStrikePriceSecurityAltIDList _listSecurityAltID = new ListStrikePriceSecurityAltIDList();
		private int _iProduct;
		private string _sCFICode;
		private string _sSecurityType;
		private string _sSecuritySubType;
		private DateTime _dtMaturityMonthYear;
		private DateTime _dtMaturityDate;
		private DateTime _dtCouponPaymentDate;
		private DateTime _dtIssueDate;
		private int _iRepoCollateralSecurityType;
		private int _iRepurchaseTerm;
		private double _dRepurchaseRate;
		private double _dFactor;
		private string _sCreditRating;
		private string _sInstrRegistry;
		private string _sCountryOfIssue;
		private string _sStateOrProvinceOfIssue;
		private string _sLocaleOfIssue;
		private DateTime _dtRedemptionDate;
		private double _dStrikePrice;
		private string _sStrikeCurrency;
		private char _cOptAttribute;
		private double _dContractMultiplier;
		private double _dCouponRate;
		private string _sSecurityExchange;
		private string _sIssuer;
		private int _iEncodedIssuerLen;
		private string _sEncodedIssuer;
		private string _sSecurityDesc;
		private int _iEncodedSecurityDescLen;
		private string _sEncodedSecurityDesc;
		private string _sPool;
		private DateTime _dtContractSettlMonth;
		private int _iCPProgram;
		private string _sCPRegType;
		private int _iNoEvents;
		private ListStrikePriceEventList _listEvent = new ListStrikePriceEventList();
		private DateTime _dtDatedDate;
		private DateTime _dtInterestAccrualDate;

		public string Symbol
		{
			get { return _sSymbol; }
			set { _sSymbol = value; }
		}
		public string SymbolSfx
		{
			get { return _sSymbolSfx; }
			set { _sSymbolSfx = value; }
		}
		public string SecurityID
		{
			get { return _sSecurityID; }
			set { _sSecurityID = value; }
		}
		public string SecurityIDSource
		{
			get { return _sSecurityIDSource; }
			set { _sSecurityIDSource = value; }
		}
		public int NoSecurityAltID
		{
			get { return _iNoSecurityAltID; }
			set { _iNoSecurityAltID = value; }
		}
		public ListStrikePriceSecurityAltIDList SecurityAltID 
		{
			get { return _listSecurityAltID; }
		}
		public int Product
		{
			get { return _iProduct; }
			set { _iProduct = value; }
		}
		public string CFICode
		{
			get { return _sCFICode; }
			set { _sCFICode = value; }
		}
		public string SecurityType
		{
			get { return _sSecurityType; }
			set { _sSecurityType = value; }
		}
		public string SecuritySubType
		{
			get { return _sSecuritySubType; }
			set { _sSecuritySubType = value; }
		}
		public DateTime MaturityMonthYear
		{
			get { return _dtMaturityMonthYear; }
			set { _dtMaturityMonthYear = value; }
		}
		public DateTime MaturityDate
		{
			get { return _dtMaturityDate; }
			set { _dtMaturityDate = value; }
		}
		public DateTime CouponPaymentDate
		{
			get { return _dtCouponPaymentDate; }
			set { _dtCouponPaymentDate = value; }
		}
		public DateTime IssueDate
		{
			get { return _dtIssueDate; }
			set { _dtIssueDate = value; }
		}
		public int RepoCollateralSecurityType
		{
			get { return _iRepoCollateralSecurityType; }
			set { _iRepoCollateralSecurityType = value; }
		}
		public int RepurchaseTerm
		{
			get { return _iRepurchaseTerm; }
			set { _iRepurchaseTerm = value; }
		}
		public double RepurchaseRate
		{
			get { return _dRepurchaseRate; }
			set { _dRepurchaseRate = value; }
		}
		public double Factor
		{
			get { return _dFactor; }
			set { _dFactor = value; }
		}
		public string CreditRating
		{
			get { return _sCreditRating; }
			set { _sCreditRating = value; }
		}
		public string InstrRegistry
		{
			get { return _sInstrRegistry; }
			set { _sInstrRegistry = value; }
		}
		public string CountryOfIssue
		{
			get { return _sCountryOfIssue; }
			set { _sCountryOfIssue = value; }
		}
		public string StateOrProvinceOfIssue
		{
			get { return _sStateOrProvinceOfIssue; }
			set { _sStateOrProvinceOfIssue = value; }
		}
		public string LocaleOfIssue
		{
			get { return _sLocaleOfIssue; }
			set { _sLocaleOfIssue = value; }
		}
		public DateTime RedemptionDate
		{
			get { return _dtRedemptionDate; }
			set { _dtRedemptionDate = value; }
		}
		public double StrikePrice
		{
			get { return _dStrikePrice; }
			set { _dStrikePrice = value; }
		}
		public string StrikeCurrency
		{
			get { return _sStrikeCurrency; }
			set { _sStrikeCurrency = value; }
		}
		public char OptAttribute
		{
			get { return _cOptAttribute; }
			set { _cOptAttribute = value; }
		}
		public double ContractMultiplier
		{
			get { return _dContractMultiplier; }
			set { _dContractMultiplier = value; }
		}
		public double CouponRate
		{
			get { return _dCouponRate; }
			set { _dCouponRate = value; }
		}
		public string SecurityExchange
		{
			get { return _sSecurityExchange; }
			set { _sSecurityExchange = value; }
		}
		public string Issuer
		{
			get { return _sIssuer; }
			set { _sIssuer = value; }
		}
		public int EncodedIssuerLen
		{
			get { return _iEncodedIssuerLen; }
			set { _iEncodedIssuerLen = value; }
		}
		public string EncodedIssuer
		{
			get { return _sEncodedIssuer; }
			set { _sEncodedIssuer = value; }
		}
		public string SecurityDesc
		{
			get { return _sSecurityDesc; }
			set { _sSecurityDesc = value; }
		}
		public int EncodedSecurityDescLen
		{
			get { return _iEncodedSecurityDescLen; }
			set { _iEncodedSecurityDescLen = value; }
		}
		public string EncodedSecurityDesc
		{
			get { return _sEncodedSecurityDesc; }
			set { _sEncodedSecurityDesc = value; }
		}
		public string Pool
		{
			get { return _sPool; }
			set { _sPool = value; }
		}
		public DateTime ContractSettlMonth
		{
			get { return _dtContractSettlMonth; }
			set { _dtContractSettlMonth = value; }
		}
		public int CPProgram
		{
			get { return _iCPProgram; }
			set { _iCPProgram = value; }
		}
		public string CPRegType
		{
			get { return _sCPRegType; }
			set { _sCPRegType = value; }
		}
		public int NoEvents
		{
			get { return _iNoEvents; }
			set { _iNoEvents = value; }
		}
		public ListStrikePriceEventList Event 
		{
			get { return _listEvent; }
		}
		public DateTime DatedDate
		{
			get { return _dtDatedDate; }
			set { _dtDatedDate = value; }
		}
		public DateTime InterestAccrualDate
		{
			get { return _dtInterestAccrualDate; }
			set { _dtInterestAccrualDate = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case ListStrikePrice.TAG_Symbol:
						return _sSymbol;
					case ListStrikePrice.TAG_SymbolSfx:
						return _sSymbolSfx;
					case ListStrikePrice.TAG_SecurityID:
						return _sSecurityID;
					case ListStrikePrice.TAG_SecurityIDSource:
						return _sSecurityIDSource;
					case ListStrikePrice.TAG_NoSecurityAltID:
						return _iNoSecurityAltID;
					case ListStrikePrice.TAG_Product:
						return _iProduct;
					case ListStrikePrice.TAG_CFICode:
						return _sCFICode;
					case ListStrikePrice.TAG_SecurityType:
						return _sSecurityType;
					case ListStrikePrice.TAG_SecuritySubType:
						return _sSecuritySubType;
					case ListStrikePrice.TAG_MaturityMonthYear:
						return _dtMaturityMonthYear;
					case ListStrikePrice.TAG_MaturityDate:
						return _dtMaturityDate;
					case ListStrikePrice.TAG_CouponPaymentDate:
						return _dtCouponPaymentDate;
					case ListStrikePrice.TAG_IssueDate:
						return _dtIssueDate;
					case ListStrikePrice.TAG_RepoCollateralSecurityType:
						return _iRepoCollateralSecurityType;
					case ListStrikePrice.TAG_RepurchaseTerm:
						return _iRepurchaseTerm;
					case ListStrikePrice.TAG_RepurchaseRate:
						return _dRepurchaseRate;
					case ListStrikePrice.TAG_Factor:
						return _dFactor;
					case ListStrikePrice.TAG_CreditRating:
						return _sCreditRating;
					case ListStrikePrice.TAG_InstrRegistry:
						return _sInstrRegistry;
					case ListStrikePrice.TAG_CountryOfIssue:
						return _sCountryOfIssue;
					case ListStrikePrice.TAG_StateOrProvinceOfIssue:
						return _sStateOrProvinceOfIssue;
					case ListStrikePrice.TAG_LocaleOfIssue:
						return _sLocaleOfIssue;
					case ListStrikePrice.TAG_RedemptionDate:
						return _dtRedemptionDate;
					case ListStrikePrice.TAG_StrikePrice:
						return _dStrikePrice;
					case ListStrikePrice.TAG_StrikeCurrency:
						return _sStrikeCurrency;
					case ListStrikePrice.TAG_OptAttribute:
						return _cOptAttribute;
					case ListStrikePrice.TAG_ContractMultiplier:
						return _dContractMultiplier;
					case ListStrikePrice.TAG_CouponRate:
						return _dCouponRate;
					case ListStrikePrice.TAG_SecurityExchange:
						return _sSecurityExchange;
					case ListStrikePrice.TAG_Issuer:
						return _sIssuer;
					case ListStrikePrice.TAG_EncodedIssuerLen:
						return _iEncodedIssuerLen;
					case ListStrikePrice.TAG_EncodedIssuer:
						return _sEncodedIssuer;
					case ListStrikePrice.TAG_SecurityDesc:
						return _sSecurityDesc;
					case ListStrikePrice.TAG_EncodedSecurityDescLen:
						return _iEncodedSecurityDescLen;
					case ListStrikePrice.TAG_EncodedSecurityDesc:
						return _sEncodedSecurityDesc;
					case ListStrikePrice.TAG_Pool:
						return _sPool;
					case ListStrikePrice.TAG_ContractSettlMonth:
						return _dtContractSettlMonth;
					case ListStrikePrice.TAG_CPProgram:
						return _iCPProgram;
					case ListStrikePrice.TAG_CPRegType:
						return _sCPRegType;
					case ListStrikePrice.TAG_NoEvents:
						return _iNoEvents;
					case ListStrikePrice.TAG_DatedDate:
						return _dtDatedDate;
					case ListStrikePrice.TAG_InterestAccrualDate:
						return _dtInterestAccrualDate;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case ListStrikePrice.TAG_Symbol:
						_sSymbol = (string)value;
						break;
					case ListStrikePrice.TAG_SymbolSfx:
						_sSymbolSfx = (string)value;
						break;
					case ListStrikePrice.TAG_SecurityID:
						_sSecurityID = (string)value;
						break;
					case ListStrikePrice.TAG_SecurityIDSource:
						_sSecurityIDSource = (string)value;
						break;
					case ListStrikePrice.TAG_NoSecurityAltID:
						_iNoSecurityAltID = (int)value;
						break;
					case ListStrikePrice.TAG_Product:
						_iProduct = (int)value;
						break;
					case ListStrikePrice.TAG_CFICode:
						_sCFICode = (string)value;
						break;
					case ListStrikePrice.TAG_SecurityType:
						_sSecurityType = (string)value;
						break;
					case ListStrikePrice.TAG_SecuritySubType:
						_sSecuritySubType = (string)value;
						break;
					case ListStrikePrice.TAG_MaturityMonthYear:
						_dtMaturityMonthYear = (DateTime)value;
						break;
					case ListStrikePrice.TAG_MaturityDate:
						_dtMaturityDate = (DateTime)value;
						break;
					case ListStrikePrice.TAG_CouponPaymentDate:
						_dtCouponPaymentDate = (DateTime)value;
						break;
					case ListStrikePrice.TAG_IssueDate:
						_dtIssueDate = (DateTime)value;
						break;
					case ListStrikePrice.TAG_RepoCollateralSecurityType:
						_iRepoCollateralSecurityType = (int)value;
						break;
					case ListStrikePrice.TAG_RepurchaseTerm:
						_iRepurchaseTerm = (int)value;
						break;
					case ListStrikePrice.TAG_RepurchaseRate:
						_dRepurchaseRate = (double)value;
						break;
					case ListStrikePrice.TAG_Factor:
						_dFactor = (double)value;
						break;
					case ListStrikePrice.TAG_CreditRating:
						_sCreditRating = (string)value;
						break;
					case ListStrikePrice.TAG_InstrRegistry:
						_sInstrRegistry = (string)value;
						break;
					case ListStrikePrice.TAG_CountryOfIssue:
						_sCountryOfIssue = (string)value;
						break;
					case ListStrikePrice.TAG_StateOrProvinceOfIssue:
						_sStateOrProvinceOfIssue = (string)value;
						break;
					case ListStrikePrice.TAG_LocaleOfIssue:
						_sLocaleOfIssue = (string)value;
						break;
					case ListStrikePrice.TAG_RedemptionDate:
						_dtRedemptionDate = (DateTime)value;
						break;
					case ListStrikePrice.TAG_StrikePrice:
						_dStrikePrice = (double)value;
						break;
					case ListStrikePrice.TAG_StrikeCurrency:
						_sStrikeCurrency = (string)value;
						break;
					case ListStrikePrice.TAG_OptAttribute:
						_cOptAttribute = (char)value;
						break;
					case ListStrikePrice.TAG_ContractMultiplier:
						_dContractMultiplier = (double)value;
						break;
					case ListStrikePrice.TAG_CouponRate:
						_dCouponRate = (double)value;
						break;
					case ListStrikePrice.TAG_SecurityExchange:
						_sSecurityExchange = (string)value;
						break;
					case ListStrikePrice.TAG_Issuer:
						_sIssuer = (string)value;
						break;
					case ListStrikePrice.TAG_EncodedIssuerLen:
						_iEncodedIssuerLen = (int)value;
						break;
					case ListStrikePrice.TAG_EncodedIssuer:
						_sEncodedIssuer = (string)value;
						break;
					case ListStrikePrice.TAG_SecurityDesc:
						_sSecurityDesc = (string)value;
						break;
					case ListStrikePrice.TAG_EncodedSecurityDescLen:
						_iEncodedSecurityDescLen = (int)value;
						break;
					case ListStrikePrice.TAG_EncodedSecurityDesc:
						_sEncodedSecurityDesc = (string)value;
						break;
					case ListStrikePrice.TAG_Pool:
						_sPool = (string)value;
						break;
					case ListStrikePrice.TAG_ContractSettlMonth:
						_dtContractSettlMonth = (DateTime)value;
						break;
					case ListStrikePrice.TAG_CPProgram:
						_iCPProgram = (int)value;
						break;
					case ListStrikePrice.TAG_CPRegType:
						_sCPRegType = (string)value;
						break;
					case ListStrikePrice.TAG_NoEvents:
						_iNoEvents = (int)value;
						break;
					case ListStrikePrice.TAG_DatedDate:
						_dtDatedDate = (DateTime)value;
						break;
					case ListStrikePrice.TAG_InterestAccrualDate:
						_dtInterestAccrualDate = (DateTime)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class ListStrikePriceStrikeList
	{
		private ArrayList _al;
		private ListStrikePriceStrike _last;

		public ListStrikePriceStrike this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (ListStrikePriceStrike)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(ListStrikePriceStrike item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(ListStrikePriceStrike item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public ListStrikePriceStrike Last
		{
			get { return _last; }
		}
	}

	public class ListStrikePriceSecurityAltID
	{
		private string _sSecurityAltID;
		private string _sSecurityAltIDSource;

		public string SecurityAltID
		{
			get { return _sSecurityAltID; }
			set { _sSecurityAltID = value; }
		}
		public string SecurityAltIDSource
		{
			get { return _sSecurityAltIDSource; }
			set { _sSecurityAltIDSource = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case ListStrikePrice.TAG_SecurityAltID:
						return _sSecurityAltID;
					case ListStrikePrice.TAG_SecurityAltIDSource:
						return _sSecurityAltIDSource;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case ListStrikePrice.TAG_SecurityAltID:
						_sSecurityAltID = (string)value;
						break;
					case ListStrikePrice.TAG_SecurityAltIDSource:
						_sSecurityAltIDSource = (string)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class ListStrikePriceSecurityAltIDList
	{
		private ArrayList _al;
		private ListStrikePriceSecurityAltID _last;

		public ListStrikePriceSecurityAltID this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (ListStrikePriceSecurityAltID)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(ListStrikePriceSecurityAltID item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(ListStrikePriceSecurityAltID item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public ListStrikePriceSecurityAltID Last
		{
			get { return _last; }
		}
	}

	public class ListStrikePriceEvent
	{
		private int _iEventType;
		private DateTime _dtEventDate;
		private double _dEventPx;
		private string _sEventText;

		public int EventType
		{
			get { return _iEventType; }
			set { _iEventType = value; }
		}
		public DateTime EventDate
		{
			get { return _dtEventDate; }
			set { _dtEventDate = value; }
		}
		public double EventPx
		{
			get { return _dEventPx; }
			set { _dEventPx = value; }
		}
		public string EventText
		{
			get { return _sEventText; }
			set { _sEventText = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case ListStrikePrice.TAG_EventType:
						return _iEventType;
					case ListStrikePrice.TAG_EventDate:
						return _dtEventDate;
					case ListStrikePrice.TAG_EventPx:
						return _dEventPx;
					case ListStrikePrice.TAG_EventText:
						return _sEventText;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case ListStrikePrice.TAG_EventType:
						_iEventType = (int)value;
						break;
					case ListStrikePrice.TAG_EventDate:
						_dtEventDate = (DateTime)value;
						break;
					case ListStrikePrice.TAG_EventPx:
						_dEventPx = (double)value;
						break;
					case ListStrikePrice.TAG_EventText:
						_sEventText = (string)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class ListStrikePriceEventList
	{
		private ArrayList _al;
		private ListStrikePriceEvent _last;

		public ListStrikePriceEvent this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (ListStrikePriceEvent)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(ListStrikePriceEvent item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(ListStrikePriceEvent item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public ListStrikePriceEvent Last
		{
			get { return _last; }
		}
	}

	public class ListStrikePriceUnderlying
	{
		private string _sUnderlyingSymbol;
		private string _sUnderlyingSymbolSfx;
		private string _sUnderlyingSecurityID;
		private string _sUnderlyingSecurityIDSource;
		private int _iNoUnderlyingSecurityAltID;
		private ListStrikePriceUnderlyingSecurityAltIDList _listUnderlyingSecurityAltID = new ListStrikePriceUnderlyingSecurityAltIDList();
		private int _iUnderlyingProduct;
		private string _sUnderlyingCFICode;
		private string _sUnderlyingSecurityType;
		private string _sUnderlyingSecuritySubType;
		private DateTime _dtUnderlyingMaturityMonthYear;
		private DateTime _dtUnderlyingMaturityDate;
		private DateTime _dtUnderlyingCouponPaymentDate;
		private DateTime _dtUnderlyingIssueDate;
		private int _iUnderlyingRepoCollateralSecurityType;
		private int _iUnderlyingRepurchaseTerm;
		private double _dUnderlyingRepurchaseRate;
		private double _dUnderlyingFactor;
		private string _sUnderlyingCreditRating;
		private string _sUnderlyingInstrRegistry;
		private string _sUnderlyingCountryOfIssue;
		private string _sUnderlyingStateOrProvinceOfIssue;
		private string _sUnderlyingLocaleOfIssue;
		private DateTime _dtUnderlyingRedemptionDate;
		private double _dUnderlyingStrikePrice;
		private string _sUnderlyingStrikeCurrency;
		private char _cUnderlyingOptAttribute;
		private double _dUnderlyingContractMultiplier;
		private double _dUnderlyingCouponRate;
		private string _sUnderlyingSecurityExchange;
		private string _sUnderlyingIssuer;
		private int _iEncodedUnderlyingIssuerLen;
		private string _sEncodedUnderlyingIssuer;
		private string _sUnderlyingSecurityDesc;
		private int _iEncodedUnderlyingSecurityDescLen;
		private string _sEncodedUnderlyingSecurityDesc;
		private string _sUnderlyingCPProgram;
		private string _sUnderlyingCPRegType;
		private string _sUnderlyingCurrency;
		private int _iUnderlyingQty;
		private double _dUnderlyingPx;
		private double _dUnderlyingDirtyPrice;
		private double _dUnderlyingEndPrice;
		private double _dUnderlyingStartValue;
		private double _dUnderlyingCurrentValue;
		private double _dUnderlyingEndValue;
		private double _dPrevClosePx;
		private string _sClOrdID;
		private string _sSecondaryClOrdID;
		private char _cSide;
		private double _dPrice;
		private string _sCurrency;
		private string _sText;
		private int _iEncodedTextLen;
		private string _sEncodedText;

		public string UnderlyingSymbol
		{
			get { return _sUnderlyingSymbol; }
			set { _sUnderlyingSymbol = value; }
		}
		public string UnderlyingSymbolSfx
		{
			get { return _sUnderlyingSymbolSfx; }
			set { _sUnderlyingSymbolSfx = value; }
		}
		public string UnderlyingSecurityID
		{
			get { return _sUnderlyingSecurityID; }
			set { _sUnderlyingSecurityID = value; }
		}
		public string UnderlyingSecurityIDSource
		{
			get { return _sUnderlyingSecurityIDSource; }
			set { _sUnderlyingSecurityIDSource = value; }
		}
		public int NoUnderlyingSecurityAltID
		{
			get { return _iNoUnderlyingSecurityAltID; }
			set { _iNoUnderlyingSecurityAltID = value; }
		}
		public ListStrikePriceUnderlyingSecurityAltIDList UnderlyingSecurityAltID 
		{
			get { return _listUnderlyingSecurityAltID; }
		}
		public int UnderlyingProduct
		{
			get { return _iUnderlyingProduct; }
			set { _iUnderlyingProduct = value; }
		}
		public string UnderlyingCFICode
		{
			get { return _sUnderlyingCFICode; }
			set { _sUnderlyingCFICode = value; }
		}
		public string UnderlyingSecurityType
		{
			get { return _sUnderlyingSecurityType; }
			set { _sUnderlyingSecurityType = value; }
		}
		public string UnderlyingSecuritySubType
		{
			get { return _sUnderlyingSecuritySubType; }
			set { _sUnderlyingSecuritySubType = value; }
		}
		public DateTime UnderlyingMaturityMonthYear
		{
			get { return _dtUnderlyingMaturityMonthYear; }
			set { _dtUnderlyingMaturityMonthYear = value; }
		}
		public DateTime UnderlyingMaturityDate
		{
			get { return _dtUnderlyingMaturityDate; }
			set { _dtUnderlyingMaturityDate = value; }
		}
		public DateTime UnderlyingCouponPaymentDate
		{
			get { return _dtUnderlyingCouponPaymentDate; }
			set { _dtUnderlyingCouponPaymentDate = value; }
		}
		public DateTime UnderlyingIssueDate
		{
			get { return _dtUnderlyingIssueDate; }
			set { _dtUnderlyingIssueDate = value; }
		}
		public int UnderlyingRepoCollateralSecurityType
		{
			get { return _iUnderlyingRepoCollateralSecurityType; }
			set { _iUnderlyingRepoCollateralSecurityType = value; }
		}
		public int UnderlyingRepurchaseTerm
		{
			get { return _iUnderlyingRepurchaseTerm; }
			set { _iUnderlyingRepurchaseTerm = value; }
		}
		public double UnderlyingRepurchaseRate
		{
			get { return _dUnderlyingRepurchaseRate; }
			set { _dUnderlyingRepurchaseRate = value; }
		}
		public double UnderlyingFactor
		{
			get { return _dUnderlyingFactor; }
			set { _dUnderlyingFactor = value; }
		}
		public string UnderlyingCreditRating
		{
			get { return _sUnderlyingCreditRating; }
			set { _sUnderlyingCreditRating = value; }
		}
		public string UnderlyingInstrRegistry
		{
			get { return _sUnderlyingInstrRegistry; }
			set { _sUnderlyingInstrRegistry = value; }
		}
		public string UnderlyingCountryOfIssue
		{
			get { return _sUnderlyingCountryOfIssue; }
			set { _sUnderlyingCountryOfIssue = value; }
		}
		public string UnderlyingStateOrProvinceOfIssue
		{
			get { return _sUnderlyingStateOrProvinceOfIssue; }
			set { _sUnderlyingStateOrProvinceOfIssue = value; }
		}
		public string UnderlyingLocaleOfIssue
		{
			get { return _sUnderlyingLocaleOfIssue; }
			set { _sUnderlyingLocaleOfIssue = value; }
		}
		public DateTime UnderlyingRedemptionDate
		{
			get { return _dtUnderlyingRedemptionDate; }
			set { _dtUnderlyingRedemptionDate = value; }
		}
		public double UnderlyingStrikePrice
		{
			get { return _dUnderlyingStrikePrice; }
			set { _dUnderlyingStrikePrice = value; }
		}
		public string UnderlyingStrikeCurrency
		{
			get { return _sUnderlyingStrikeCurrency; }
			set { _sUnderlyingStrikeCurrency = value; }
		}
		public char UnderlyingOptAttribute
		{
			get { return _cUnderlyingOptAttribute; }
			set { _cUnderlyingOptAttribute = value; }
		}
		public double UnderlyingContractMultiplier
		{
			get { return _dUnderlyingContractMultiplier; }
			set { _dUnderlyingContractMultiplier = value; }
		}
		public double UnderlyingCouponRate
		{
			get { return _dUnderlyingCouponRate; }
			set { _dUnderlyingCouponRate = value; }
		}
		public string UnderlyingSecurityExchange
		{
			get { return _sUnderlyingSecurityExchange; }
			set { _sUnderlyingSecurityExchange = value; }
		}
		public string UnderlyingIssuer
		{
			get { return _sUnderlyingIssuer; }
			set { _sUnderlyingIssuer = value; }
		}
		public int EncodedUnderlyingIssuerLen
		{
			get { return _iEncodedUnderlyingIssuerLen; }
			set { _iEncodedUnderlyingIssuerLen = value; }
		}
		public string EncodedUnderlyingIssuer
		{
			get { return _sEncodedUnderlyingIssuer; }
			set { _sEncodedUnderlyingIssuer = value; }
		}
		public string UnderlyingSecurityDesc
		{
			get { return _sUnderlyingSecurityDesc; }
			set { _sUnderlyingSecurityDesc = value; }
		}
		public int EncodedUnderlyingSecurityDescLen
		{
			get { return _iEncodedUnderlyingSecurityDescLen; }
			set { _iEncodedUnderlyingSecurityDescLen = value; }
		}
		public string EncodedUnderlyingSecurityDesc
		{
			get { return _sEncodedUnderlyingSecurityDesc; }
			set { _sEncodedUnderlyingSecurityDesc = value; }
		}
		public string UnderlyingCPProgram
		{
			get { return _sUnderlyingCPProgram; }
			set { _sUnderlyingCPProgram = value; }
		}
		public string UnderlyingCPRegType
		{
			get { return _sUnderlyingCPRegType; }
			set { _sUnderlyingCPRegType = value; }
		}
		public string UnderlyingCurrency
		{
			get { return _sUnderlyingCurrency; }
			set { _sUnderlyingCurrency = value; }
		}
		public int UnderlyingQty
		{
			get { return _iUnderlyingQty; }
			set { _iUnderlyingQty = value; }
		}
		public double UnderlyingPx
		{
			get { return _dUnderlyingPx; }
			set { _dUnderlyingPx = value; }
		}
		public double UnderlyingDirtyPrice
		{
			get { return _dUnderlyingDirtyPrice; }
			set { _dUnderlyingDirtyPrice = value; }
		}
		public double UnderlyingEndPrice
		{
			get { return _dUnderlyingEndPrice; }
			set { _dUnderlyingEndPrice = value; }
		}
		public double UnderlyingStartValue
		{
			get { return _dUnderlyingStartValue; }
			set { _dUnderlyingStartValue = value; }
		}
		public double UnderlyingCurrentValue
		{
			get { return _dUnderlyingCurrentValue; }
			set { _dUnderlyingCurrentValue = value; }
		}
		public double UnderlyingEndValue
		{
			get { return _dUnderlyingEndValue; }
			set { _dUnderlyingEndValue = value; }
		}
		public double PrevClosePx
		{
			get { return _dPrevClosePx; }
			set { _dPrevClosePx = value; }
		}
		public string ClOrdID
		{
			get { return _sClOrdID; }
			set { _sClOrdID = value; }
		}
		public string SecondaryClOrdID
		{
			get { return _sSecondaryClOrdID; }
			set { _sSecondaryClOrdID = value; }
		}
		public char Side
		{
			get { return _cSide; }
			set { _cSide = value; }
		}
		public double Price
		{
			get { return _dPrice; }
			set { _dPrice = value; }
		}
		public string Currency
		{
			get { return _sCurrency; }
			set { _sCurrency = value; }
		}
		public string Text
		{
			get { return _sText; }
			set { _sText = value; }
		}
		public int EncodedTextLen
		{
			get { return _iEncodedTextLen; }
			set { _iEncodedTextLen = value; }
		}
		public string EncodedText
		{
			get { return _sEncodedText; }
			set { _sEncodedText = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case ListStrikePrice.TAG_UnderlyingSymbol:
						return _sUnderlyingSymbol;
					case ListStrikePrice.TAG_UnderlyingSymbolSfx:
						return _sUnderlyingSymbolSfx;
					case ListStrikePrice.TAG_UnderlyingSecurityID:
						return _sUnderlyingSecurityID;
					case ListStrikePrice.TAG_UnderlyingSecurityIDSource:
						return _sUnderlyingSecurityIDSource;
					case ListStrikePrice.TAG_NoUnderlyingSecurityAltID:
						return _iNoUnderlyingSecurityAltID;
					case ListStrikePrice.TAG_UnderlyingProduct:
						return _iUnderlyingProduct;
					case ListStrikePrice.TAG_UnderlyingCFICode:
						return _sUnderlyingCFICode;
					case ListStrikePrice.TAG_UnderlyingSecurityType:
						return _sUnderlyingSecurityType;
					case ListStrikePrice.TAG_UnderlyingSecuritySubType:
						return _sUnderlyingSecuritySubType;
					case ListStrikePrice.TAG_UnderlyingMaturityMonthYear:
						return _dtUnderlyingMaturityMonthYear;
					case ListStrikePrice.TAG_UnderlyingMaturityDate:
						return _dtUnderlyingMaturityDate;
					case ListStrikePrice.TAG_UnderlyingCouponPaymentDate:
						return _dtUnderlyingCouponPaymentDate;
					case ListStrikePrice.TAG_UnderlyingIssueDate:
						return _dtUnderlyingIssueDate;
					case ListStrikePrice.TAG_UnderlyingRepoCollateralSecurityType:
						return _iUnderlyingRepoCollateralSecurityType;
					case ListStrikePrice.TAG_UnderlyingRepurchaseTerm:
						return _iUnderlyingRepurchaseTerm;
					case ListStrikePrice.TAG_UnderlyingRepurchaseRate:
						return _dUnderlyingRepurchaseRate;
					case ListStrikePrice.TAG_UnderlyingFactor:
						return _dUnderlyingFactor;
					case ListStrikePrice.TAG_UnderlyingCreditRating:
						return _sUnderlyingCreditRating;
					case ListStrikePrice.TAG_UnderlyingInstrRegistry:
						return _sUnderlyingInstrRegistry;
					case ListStrikePrice.TAG_UnderlyingCountryOfIssue:
						return _sUnderlyingCountryOfIssue;
					case ListStrikePrice.TAG_UnderlyingStateOrProvinceOfIssue:
						return _sUnderlyingStateOrProvinceOfIssue;
					case ListStrikePrice.TAG_UnderlyingLocaleOfIssue:
						return _sUnderlyingLocaleOfIssue;
					case ListStrikePrice.TAG_UnderlyingRedemptionDate:
						return _dtUnderlyingRedemptionDate;
					case ListStrikePrice.TAG_UnderlyingStrikePrice:
						return _dUnderlyingStrikePrice;
					case ListStrikePrice.TAG_UnderlyingStrikeCurrency:
						return _sUnderlyingStrikeCurrency;
					case ListStrikePrice.TAG_UnderlyingOptAttribute:
						return _cUnderlyingOptAttribute;
					case ListStrikePrice.TAG_UnderlyingContractMultiplier:
						return _dUnderlyingContractMultiplier;
					case ListStrikePrice.TAG_UnderlyingCouponRate:
						return _dUnderlyingCouponRate;
					case ListStrikePrice.TAG_UnderlyingSecurityExchange:
						return _sUnderlyingSecurityExchange;
					case ListStrikePrice.TAG_UnderlyingIssuer:
						return _sUnderlyingIssuer;
					case ListStrikePrice.TAG_EncodedUnderlyingIssuerLen:
						return _iEncodedUnderlyingIssuerLen;
					case ListStrikePrice.TAG_EncodedUnderlyingIssuer:
						return _sEncodedUnderlyingIssuer;
					case ListStrikePrice.TAG_UnderlyingSecurityDesc:
						return _sUnderlyingSecurityDesc;
					case ListStrikePrice.TAG_EncodedUnderlyingSecurityDescLen:
						return _iEncodedUnderlyingSecurityDescLen;
					case ListStrikePrice.TAG_EncodedUnderlyingSecurityDesc:
						return _sEncodedUnderlyingSecurityDesc;
					case ListStrikePrice.TAG_UnderlyingCPProgram:
						return _sUnderlyingCPProgram;
					case ListStrikePrice.TAG_UnderlyingCPRegType:
						return _sUnderlyingCPRegType;
					case ListStrikePrice.TAG_UnderlyingCurrency:
						return _sUnderlyingCurrency;
					case ListStrikePrice.TAG_UnderlyingQty:
						return _iUnderlyingQty;
					case ListStrikePrice.TAG_UnderlyingPx:
						return _dUnderlyingPx;
					case ListStrikePrice.TAG_UnderlyingDirtyPrice:
						return _dUnderlyingDirtyPrice;
					case ListStrikePrice.TAG_UnderlyingEndPrice:
						return _dUnderlyingEndPrice;
					case ListStrikePrice.TAG_UnderlyingStartValue:
						return _dUnderlyingStartValue;
					case ListStrikePrice.TAG_UnderlyingCurrentValue:
						return _dUnderlyingCurrentValue;
					case ListStrikePrice.TAG_UnderlyingEndValue:
						return _dUnderlyingEndValue;
					case ListStrikePrice.TAG_PrevClosePx:
						return _dPrevClosePx;
					case ListStrikePrice.TAG_ClOrdID:
						return _sClOrdID;
					case ListStrikePrice.TAG_SecondaryClOrdID:
						return _sSecondaryClOrdID;
					case ListStrikePrice.TAG_Side:
						return _cSide;
					case ListStrikePrice.TAG_Price:
						return _dPrice;
					case ListStrikePrice.TAG_Currency:
						return _sCurrency;
					case ListStrikePrice.TAG_Text:
						return _sText;
					case ListStrikePrice.TAG_EncodedTextLen:
						return _iEncodedTextLen;
					case ListStrikePrice.TAG_EncodedText:
						return _sEncodedText;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case ListStrikePrice.TAG_UnderlyingSymbol:
						_sUnderlyingSymbol = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingSymbolSfx:
						_sUnderlyingSymbolSfx = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingSecurityID:
						_sUnderlyingSecurityID = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingSecurityIDSource:
						_sUnderlyingSecurityIDSource = (string)value;
						break;
					case ListStrikePrice.TAG_NoUnderlyingSecurityAltID:
						_iNoUnderlyingSecurityAltID = (int)value;
						break;
					case ListStrikePrice.TAG_UnderlyingProduct:
						_iUnderlyingProduct = (int)value;
						break;
					case ListStrikePrice.TAG_UnderlyingCFICode:
						_sUnderlyingCFICode = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingSecurityType:
						_sUnderlyingSecurityType = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingSecuritySubType:
						_sUnderlyingSecuritySubType = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingMaturityMonthYear:
						_dtUnderlyingMaturityMonthYear = (DateTime)value;
						break;
					case ListStrikePrice.TAG_UnderlyingMaturityDate:
						_dtUnderlyingMaturityDate = (DateTime)value;
						break;
					case ListStrikePrice.TAG_UnderlyingCouponPaymentDate:
						_dtUnderlyingCouponPaymentDate = (DateTime)value;
						break;
					case ListStrikePrice.TAG_UnderlyingIssueDate:
						_dtUnderlyingIssueDate = (DateTime)value;
						break;
					case ListStrikePrice.TAG_UnderlyingRepoCollateralSecurityType:
						_iUnderlyingRepoCollateralSecurityType = (int)value;
						break;
					case ListStrikePrice.TAG_UnderlyingRepurchaseTerm:
						_iUnderlyingRepurchaseTerm = (int)value;
						break;
					case ListStrikePrice.TAG_UnderlyingRepurchaseRate:
						_dUnderlyingRepurchaseRate = (double)value;
						break;
					case ListStrikePrice.TAG_UnderlyingFactor:
						_dUnderlyingFactor = (double)value;
						break;
					case ListStrikePrice.TAG_UnderlyingCreditRating:
						_sUnderlyingCreditRating = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingInstrRegistry:
						_sUnderlyingInstrRegistry = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingCountryOfIssue:
						_sUnderlyingCountryOfIssue = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingStateOrProvinceOfIssue:
						_sUnderlyingStateOrProvinceOfIssue = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingLocaleOfIssue:
						_sUnderlyingLocaleOfIssue = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingRedemptionDate:
						_dtUnderlyingRedemptionDate = (DateTime)value;
						break;
					case ListStrikePrice.TAG_UnderlyingStrikePrice:
						_dUnderlyingStrikePrice = (double)value;
						break;
					case ListStrikePrice.TAG_UnderlyingStrikeCurrency:
						_sUnderlyingStrikeCurrency = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingOptAttribute:
						_cUnderlyingOptAttribute = (char)value;
						break;
					case ListStrikePrice.TAG_UnderlyingContractMultiplier:
						_dUnderlyingContractMultiplier = (double)value;
						break;
					case ListStrikePrice.TAG_UnderlyingCouponRate:
						_dUnderlyingCouponRate = (double)value;
						break;
					case ListStrikePrice.TAG_UnderlyingSecurityExchange:
						_sUnderlyingSecurityExchange = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingIssuer:
						_sUnderlyingIssuer = (string)value;
						break;
					case ListStrikePrice.TAG_EncodedUnderlyingIssuerLen:
						_iEncodedUnderlyingIssuerLen = (int)value;
						break;
					case ListStrikePrice.TAG_EncodedUnderlyingIssuer:
						_sEncodedUnderlyingIssuer = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingSecurityDesc:
						_sUnderlyingSecurityDesc = (string)value;
						break;
					case ListStrikePrice.TAG_EncodedUnderlyingSecurityDescLen:
						_iEncodedUnderlyingSecurityDescLen = (int)value;
						break;
					case ListStrikePrice.TAG_EncodedUnderlyingSecurityDesc:
						_sEncodedUnderlyingSecurityDesc = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingCPProgram:
						_sUnderlyingCPProgram = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingCPRegType:
						_sUnderlyingCPRegType = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingCurrency:
						_sUnderlyingCurrency = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingQty:
						_iUnderlyingQty = (int)value;
						break;
					case ListStrikePrice.TAG_UnderlyingPx:
						_dUnderlyingPx = (double)value;
						break;
					case ListStrikePrice.TAG_UnderlyingDirtyPrice:
						_dUnderlyingDirtyPrice = (double)value;
						break;
					case ListStrikePrice.TAG_UnderlyingEndPrice:
						_dUnderlyingEndPrice = (double)value;
						break;
					case ListStrikePrice.TAG_UnderlyingStartValue:
						_dUnderlyingStartValue = (double)value;
						break;
					case ListStrikePrice.TAG_UnderlyingCurrentValue:
						_dUnderlyingCurrentValue = (double)value;
						break;
					case ListStrikePrice.TAG_UnderlyingEndValue:
						_dUnderlyingEndValue = (double)value;
						break;
					case ListStrikePrice.TAG_PrevClosePx:
						_dPrevClosePx = (double)value;
						break;
					case ListStrikePrice.TAG_ClOrdID:
						_sClOrdID = (string)value;
						break;
					case ListStrikePrice.TAG_SecondaryClOrdID:
						_sSecondaryClOrdID = (string)value;
						break;
					case ListStrikePrice.TAG_Side:
						_cSide = (char)value;
						break;
					case ListStrikePrice.TAG_Price:
						_dPrice = (double)value;
						break;
					case ListStrikePrice.TAG_Currency:
						_sCurrency = (string)value;
						break;
					case ListStrikePrice.TAG_Text:
						_sText = (string)value;
						break;
					case ListStrikePrice.TAG_EncodedTextLen:
						_iEncodedTextLen = (int)value;
						break;
					case ListStrikePrice.TAG_EncodedText:
						_sEncodedText = (string)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class ListStrikePriceUnderlyingList
	{
		private ArrayList _al;
		private ListStrikePriceUnderlying _last;

		public ListStrikePriceUnderlying this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (ListStrikePriceUnderlying)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(ListStrikePriceUnderlying item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(ListStrikePriceUnderlying item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public ListStrikePriceUnderlying Last
		{
			get { return _last; }
		}
	}

	public class ListStrikePriceUnderlyingSecurityAltID
	{
		private string _sUnderlyingSecurityAltID;
		private string _sUnderlyingSecurityAltIDSource;

		public string UnderlyingSecurityAltID
		{
			get { return _sUnderlyingSecurityAltID; }
			set { _sUnderlyingSecurityAltID = value; }
		}
		public string UnderlyingSecurityAltIDSource
		{
			get { return _sUnderlyingSecurityAltIDSource; }
			set { _sUnderlyingSecurityAltIDSource = value; }
		}

		public object this[int iTag]
		{
			get
			{
				switch (iTag)
				{
					case ListStrikePrice.TAG_UnderlyingSecurityAltID:
						return _sUnderlyingSecurityAltID;
					case ListStrikePrice.TAG_UnderlyingSecurityAltIDSource:
						return _sUnderlyingSecurityAltIDSource;
					default:
						throw new Exception("Unknown field");
				}
			}
			set
			{
				switch (iTag)
				{
					case ListStrikePrice.TAG_UnderlyingSecurityAltID:
						_sUnderlyingSecurityAltID = (string)value;
						break;
					case ListStrikePrice.TAG_UnderlyingSecurityAltIDSource:
						_sUnderlyingSecurityAltIDSource = (string)value;
						break;
					default:
						throw new Exception("Unknown field");
				}
			}
		}
	}

	public class ListStrikePriceUnderlyingSecurityAltIDList
	{
		private ArrayList _al;
		private ListStrikePriceUnderlyingSecurityAltID _last;

		public ListStrikePriceUnderlyingSecurityAltID this[int i]
		{
			get
			{
				if (_al != null && i < _al.Count)
					return (ListStrikePriceUnderlyingSecurityAltID)_al[i];
				else
					return null;
			}
		}

		public int Count
		{
			get
			{
				if (_al != null)
					return _al.Count;
				else
					return 0;
			}
		}

		public void Clear()
		{
			_al = null;
		}

		public void Add(ListStrikePriceUnderlyingSecurityAltID item)
		{
			if (_al == null)
				_al = new ArrayList();
			_al.Add(item);
			_last = item;
		}

		public void Remove(ListStrikePriceUnderlyingSecurityAltID item)
		{
			if (_al != null)
				_al.Remove(item);
		}

		public void RemoveAt(int iIndex)
		{
			if (_al != null && iIndex < _al.Count)
				_al.RemoveAt(iIndex);
		}

		public ListStrikePriceUnderlyingSecurityAltID Last
		{
			get { return _last; }
		}
	}
}
