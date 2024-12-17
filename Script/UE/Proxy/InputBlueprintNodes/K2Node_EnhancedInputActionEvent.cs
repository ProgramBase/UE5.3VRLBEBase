using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.EnhancedInput;
using Script.Library;

namespace Script.InputBlueprintNodes
{
	[PathName("/Script/InputBlueprintNodes.K2Node_EnhancedInputActionEvent")]
	public partial class UK2Node_EnhancedInputActionEvent : UK2Node_Event, IStaticClass
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

		public ETriggerEvent TriggerEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TriggerEvent, __ReturnBuffer);

					return *(ETriggerEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TriggerEvent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputBlueprintNodes.K2Node_EnhancedInputActionEvent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputAction = 0;

		private static uint __TriggerEvent = 0;
	}
}