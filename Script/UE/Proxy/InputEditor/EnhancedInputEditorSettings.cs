using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.InputEditor
{
	[PathName("/Script/InputEditor.EnhancedInputEditorSettings")]
	public partial class UEnhancedInputEditorSettings : UDeveloperSettingsBackedByCVars, IStaticClass
	{
		public bool bLogAllInput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLogAllInput, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLogAllInput, __InBuffer);
				}
			}
		}

		public bool bAutomaticallyStartConsumingInput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutomaticallyStartConsumingInput, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutomaticallyStartConsumingInput, __InBuffer);
				}
			}
		}

		public byte VisibleEventPinsByDefault
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VisibleEventPinsByDefault, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VisibleEventPinsByDefault, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InputEditor.EnhancedInputEditorSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bLogAllInput = 0;

		private static uint __bAutomaticallyStartConsumingInput = 0;

		private static uint __VisibleEventPinsByDefault = 0;
	}
}