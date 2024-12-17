using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.FoliageDensityFalloff")]
	public partial class FFoliageDensityFalloff : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Foliage.FoliageDensityFalloff");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFoliageDensityFalloff() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFoliageDensityFalloff() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFoliageDensityFalloff A, FFoliageDensityFalloff B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFoliageDensityFalloff A, FFoliageDensityFalloff B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFoliageDensityFalloff;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bUseFalloffCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUseFalloffCurve, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUseFalloffCurve, __InBuffer);
				}
			}
		}

		public FRuntimeFloatCurve FalloffCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FalloffCurve, __ReturnBuffer);

					return *(FRuntimeFloatCurve*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FalloffCurve, __InBuffer);
				}
			}
		}

		private static uint __bUseFalloffCurve = 0;

		private static uint __FalloffCurve = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}