using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ScalarParameterAtlasInstanceData")]
	public partial class FScalarParameterAtlasInstanceData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ScalarParameterAtlasInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FScalarParameterAtlasInstanceData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FScalarParameterAtlasInstanceData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FScalarParameterAtlasInstanceData A, FScalarParameterAtlasInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FScalarParameterAtlasInstanceData A, FScalarParameterAtlasInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FScalarParameterAtlasInstanceData;

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