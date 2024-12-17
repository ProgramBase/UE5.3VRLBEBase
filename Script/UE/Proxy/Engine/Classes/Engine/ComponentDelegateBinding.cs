using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ComponentDelegateBinding")]
	public partial class UComponentDelegateBinding : UDynamicBlueprintBinding, IStaticClass
	{
		public TArray<FBlueprintComponentDelegateBinding> ComponentDelegateBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentDelegateBindings, __ReturnBuffer);

					return *(TArray<FBlueprintComponentDelegateBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentDelegateBindings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ComponentDelegateBinding");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ComponentDelegateBindings = 0;
	}
}