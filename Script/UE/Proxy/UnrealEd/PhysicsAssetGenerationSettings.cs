using Script.CoreUObject;
using Script.PhysicsUtilities;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PhysicsAssetGenerationSettings")]
	public partial class UPhysicsAssetGenerationSettings : UObject, IStaticClass
	{
		public FPhysAssetCreateParams CreateParams
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CreateParams, __ReturnBuffer);

					return *(FPhysAssetCreateParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CreateParams, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PhysicsAssetGenerationSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CreateParams = 0;
	}
}