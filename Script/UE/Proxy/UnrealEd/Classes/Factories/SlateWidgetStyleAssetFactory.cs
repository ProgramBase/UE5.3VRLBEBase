using Script.CoreUObject;
using Script.SlateCore;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.SlateWidgetStyleAssetFactory")]
	public partial class USlateWidgetStyleAssetFactory : UFactory, IStaticClass
	{
		public TSubclassOf<USlateWidgetStyleContainerBase> StyleType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StyleType, __ReturnBuffer);

					return *(TSubclassOf<USlateWidgetStyleContainerBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StyleType, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.SlateWidgetStyleAssetFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __StyleType = 0;
	}
}