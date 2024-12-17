using Script.CoreUObject;
using Script.PhysicsCore;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PhysicalMaterialFactoryNew")]
	public partial class UPhysicalMaterialFactoryNew : UFactory, IStaticClass
	{
		public TSubclassOf<UPhysicalMaterial> PhysicalMaterialClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicalMaterialClass, __ReturnBuffer);

					return *(TSubclassOf<UPhysicalMaterial>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicalMaterialClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PhysicalMaterialFactoryNew");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PhysicalMaterialClass = 0;
	}
}