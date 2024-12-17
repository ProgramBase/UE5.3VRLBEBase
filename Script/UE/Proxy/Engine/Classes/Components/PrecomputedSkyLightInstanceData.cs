using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PrecomputedSkyLightInstanceData")]
	public partial class FPrecomputedSkyLightInstanceData : FSceneComponentInstanceData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PrecomputedSkyLightInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPrecomputedSkyLightInstanceData()
		{
		}

		public static bool operator ==(FPrecomputedSkyLightInstanceData A, FPrecomputedSkyLightInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPrecomputedSkyLightInstanceData A, FPrecomputedSkyLightInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPrecomputedSkyLightInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid LightGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LightGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LightGuid, __InBuffer);
				}
			}
		}

		public float AverageBrightness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AverageBrightness, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AverageBrightness, __InBuffer);
				}
			}
		}

		private static uint __LightGuid = 0;

		private static uint __AverageBrightness = 0;

	}
}