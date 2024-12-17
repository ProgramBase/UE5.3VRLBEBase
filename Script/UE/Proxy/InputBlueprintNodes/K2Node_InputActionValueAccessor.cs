using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.EnhancedInput;
using Script.Library;

namespace Script.InputBlueprintNodes
{
	[PathName("/Script/InputBlueprintNodes.K2Node_InputActionValueAccessor")]
	public partial class UK2Node_InputActionValueAccessor : UK2Node_CallFunction, IStaticClass
	{
		public UInputAction InputAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputAction, __ReturnBuffer);

					return *(UInputAction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputAction, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputBlueprintNodes.K2Node_InputActionValueAccessor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputAction = 0;
	}
}