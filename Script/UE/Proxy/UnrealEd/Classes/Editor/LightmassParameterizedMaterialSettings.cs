using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LightmassParameterizedMaterialSettings")]
	public partial class FLightmassParameterizedMaterialSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/UnrealEd.LightmassParameterizedMaterialSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLightmassParameterizedMaterialSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLightmassParameterizedMaterialSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLightmassParameterizedMaterialSettings A, FLightmassParameterizedMaterialSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLightmassParameterizedMaterialSettings A, FLightmassParameterizedMaterialSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLightmassParameterizedMaterialSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FLightmassBooleanParameterValue CastShadowAsMasked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CastShadowAsMasked, __ReturnBuffer);

					return *(FLightmassBooleanParameterValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CastShadowAsMasked, __InBuffer);
				}
			}
		}

		public FLightmassScalarParameterValue EmissiveBoost
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EmissiveBoost, __ReturnBuffer);

					return *(FLightmassScalarParameterValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EmissiveBoost, __InBuffer);
				}
			}
		}

		public FLightmassScalarParameterValue DiffuseBoost
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DiffuseBoost, __ReturnBuffer);

					return *(FLightmassScalarParameterValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DiffuseBoost, __InBuffer);
				}
			}
		}

		public FLightmassScalarParameterValue ExportResolutionScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExportResolutionScale, __ReturnBuffer);

					return *(FLightmassScalarParameterValue*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExportResolutionScale, __InBuffer);
				}
			}
		}

		private static uint __CastShadowAsMasked = 0;

		private static uint __EmissiveBoost = 0;

		private static uint __DiffuseBoost = 0;

		private static uint __ExportResolutionScale = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}