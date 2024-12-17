using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.PhysicalMaterialMaskFactory")]
	public partial class UPhysicalMaterialMaskFactory : UFactory, IStaticClass
	{
		public TSubclassOf<UPhysicalMaterialMask> PhysicalMaterialMaskClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicalMaterialMaskClass, __ReturnBuffer);

					return *(TSubclassOf<UPhysicalMaterialMask>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicalMaterialMaskClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.PhysicalMaterialMaskFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PhysicalMaterialMaskClass = 0;
	}
}