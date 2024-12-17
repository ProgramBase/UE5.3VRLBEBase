using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.LocalizationExportingSettings")]
	public partial class FLocalizationExportingSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Localization.LocalizationExportingSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLocalizationExportingSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLocalizationExportingSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLocalizationExportingSettings A, FLocalizationExportingSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLocalizationExportingSettings A, FLocalizationExportingSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLocalizationExportingSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ELocalizedTextCollapseMode CollapseMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CollapseMode, __ReturnBuffer);

					return *(ELocalizedTextCollapseMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CollapseMode, __InBuffer);
				}
			}
		}

		public EPortableObjectFormat POFormat
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __POFormat, __ReturnBuffer);

					return *(EPortableObjectFormat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __POFormat, __InBuffer);
				}
			}
		}

		public bool ShouldPersistCommentsOnExport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShouldPersistCommentsOnExport, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShouldPersistCommentsOnExport, __InBuffer);
				}
			}
		}

		public bool ShouldAddSourceLocationsAsComments
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShouldAddSourceLocationsAsComments, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShouldAddSourceLocationsAsComments, __InBuffer);
				}
			}
		}

		private static uint __CollapseMode = 0;

		private static uint __POFormat = 0;

		private static uint __ShouldPersistCommentsOnExport = 0;

		private static uint __ShouldAddSourceLocationsAsComments = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}