using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ScalarParameterAtlasData")]
	public partial class FScalarParameterAtlasData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.ScalarParameterAtlasData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FScalarParameterAtlasData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FScalarParameterAtlasData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FScalarParameterAtlasData A, FScalarParameterAtlasData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FScalarParameterAtlasData A, FScalarParameterAtlasData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FScalarParameterAtlasData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bIsUsedAsAtlasPosition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsUsedAsAtlasPosition, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsUsedAsAtlasPosition, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UCurveLinearColor> Curve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Curve, __ReturnBuffer);

					return *(TSoftObjectPtr<UCurveLinearColor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Curve, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UCurveLinearColorAtlas> Atlas
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Atlas, __ReturnBuffer);

					return *(TSoftObjectPtr<UCurveLinearColorAtlas>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Atlas, __InBuffer);
				}
			}
		}

		private static uint __bIsUsedAsAtlasPosition = 0;

		private static uint __Curve = 0;

		private static uint __Atlas = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}