using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Slate;
using Script.Engine;
using Script.Library;

namespace Script.InputBlueprintNodes
{
	[PathName("/Script/InputBlueprintNodes.K2Node_InputDebugKeyEvent")]
	public partial class UK2Node_InputDebugKeyEvent : UK2Node_Event, IStaticClass
	{
		public FInputChord InputChord
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputChord, __ReturnBuffer);

					return *(FInputChord*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputChord, __InBuffer);
				}
			}
		}

		public EInputEvent InputKeyEvent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputKeyEvent, __ReturnBuffer);

					return *(EInputEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputKeyEvent, __InBuffer);
				}
			}
		}

		public bool bExecuteWhenPaused
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bExecuteWhenPaused, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bExecuteWhenPaused, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputBlueprintNodes.K2Node_InputDebugKeyEvent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputChord = 0;

		private static uint __InputKeyEvent = 0;

		private static uint __bExecuteWhenPaused = 0;
	}
}