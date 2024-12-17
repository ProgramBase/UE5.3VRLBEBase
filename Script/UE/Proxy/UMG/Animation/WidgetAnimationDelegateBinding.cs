using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetAnimationDelegateBinding")]
	public partial class UWidgetAnimationDelegateBinding : UDynamicBlueprintBinding, IStaticClass
	{
		public TArray<FBlueprintWidgetAnimationDelegateBinding> WidgetAnimationDelegateBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetAnimationDelegateBindings, __ReturnBuffer);

					return *(TArray<FBlueprintWidgetAnimationDelegateBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetAnimationDelegateBindings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetAnimationDelegateBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __WidgetAnimationDelegateBindings = 0;
	}
}