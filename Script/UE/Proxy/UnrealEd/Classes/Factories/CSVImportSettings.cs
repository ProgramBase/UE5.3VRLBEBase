using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.CSVImportSettings")]
	public partial class FCSVImportSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.CSVImportSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCSVImportSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCSVImportSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCSVImportSettings A, FCSVImportSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCSVImportSettings A, FCSVImportSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCSVImportSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UScriptStruct ImportRowStruct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImportRowStruct, __ReturnBuffer);

					return *(UScriptStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImportRowStruct, __InBuffer);
				}
			}
		}

		public ECSVImportType ImportType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImportType, __ReturnBuffer);

					return *(ECSVImportType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImportType, __InBuffer);
				}
			}
		}

		public ERichCurveInterpMode ImportCurveInterpMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ImportCurveInterpMode, __ReturnBuffer);

					return *(ERichCurveInterpMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ImportCurveInterpMode, __InBuffer);
				}
			}
		}

		private static uint __ImportRowStruct = 0;

		private static uint __ImportType = 0;

		private static uint __ImportCurveInterpMode = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}