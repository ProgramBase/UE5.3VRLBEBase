using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.SphereWithOwnerBoostNetObjectPrioritizerConfig")]
	public partial class USphereWithOwnerBoostNetObjectPrioritizerConfig : USphereNetObjectPrioritizerConfig, IStaticClass
	{
		public float OwnerPriorityBoost
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwnerPriorityBoost, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwnerPriorityBoost, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.SphereWithOwnerBoostNetObjectPrioritizerConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OwnerPriorityBoost = 0;
	}
}