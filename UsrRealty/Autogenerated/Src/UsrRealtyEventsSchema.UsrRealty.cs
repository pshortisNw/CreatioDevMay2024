namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrRealtyEventsSchema

	/// <exclude/>
	public class UsrRealtyEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrRealtyEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrRealtyEventsSchema(UsrRealtyEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("deb4cd9d-bce3-4e77-a202-19c8fe2f412b");
			Name = "UsrRealtyEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("059e8221-ac2b-45f5-bfcd-596a5b88c135");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,133,82,77,107,220,48,16,61,59,144,255,48,152,30,108,88,68,114,109,218,64,119,179,41,129,208,150,216,219,75,201,65,43,207,58,10,250,48,146,188,233,182,244,191,119,36,217,105,105,182,196,200,2,205,188,247,230,141,52,134,107,244,3,23,8,45,58,199,189,221,5,182,178,102,39,251,209,241,32,173,57,61,249,121,122,82,140,94,154,30,154,131,15,168,47,158,207,127,83,180,182,230,120,198,33,91,155,32,131,68,255,42,128,173,247,104,66,194,125,75,177,67,10,220,74,42,108,208,85,141,120,64,205,63,145,105,120,15,229,198,187,59,228,42,28,202,250,158,24,195,184,85,82,128,80,220,123,200,137,35,26,240,22,150,220,227,145,12,73,196,94,103,29,187,39,143,178,67,216,91,217,193,103,211,240,61,57,175,236,246,17,69,0,143,166,67,183,128,172,179,196,29,181,145,212,62,184,222,3,214,81,40,169,21,91,170,198,158,233,51,15,235,139,148,205,124,112,201,46,53,85,229,64,157,113,25,211,161,144,154,43,24,156,20,177,241,12,102,31,49,180,135,1,187,149,85,163,54,95,185,26,241,221,4,189,172,226,229,124,137,248,77,115,85,78,181,228,14,170,172,113,9,231,103,243,151,172,78,94,11,100,55,126,197,141,64,133,29,85,10,110,68,226,230,156,15,46,62,29,13,140,231,61,182,168,7,197,67,244,99,240,9,110,173,224,74,254,224,91,133,77,194,85,147,203,141,71,71,19,101,232,210,104,156,216,29,122,59,58,65,32,235,72,101,145,165,139,226,207,99,230,17,40,23,80,190,208,244,44,117,121,227,91,107,151,178,207,167,178,102,173,157,106,214,255,49,75,38,115,128,93,91,167,121,168,254,105,130,138,157,179,179,229,155,249,166,138,240,224,236,83,106,108,253,93,224,16,173,207,156,9,242,43,238,113,163,159,214,111,13,156,218,227,73,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("fb8c6750-5591-f903-8ed9-a4a65a40fb42"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("059e8221-ac2b-45f5-bfcd-596a5b88c135"),
				CreatedInSchemaUId = new Guid("deb4cd9d-bce3-4e77-a202-19c8fe2f412b"),
				ModifiedInSchemaUId = new Guid("deb4cd9d-bce3-4e77-a202-19c8fe2f412b")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("deb4cd9d-bce3-4e77-a202-19c8fe2f412b"));
		}

		#endregion

	}

	#endregion

}

