using Script.CoreUObject;
using Script.UMGEditor;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityWidgetBlueprint")]
	public partial class UEditorUtilityWidgetBlueprint : UWidgetBlueprint, IStaticClass
	{
		public bool bIsEnabledInPIE
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabledInPIE, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabledInPIE, __InBuffer);
				}
			}
		}

		public bool bIsEnabledInDebugging
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabledInDebugging, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsEnabledInDebugging, __InBuffer);
				}
			}
		}

		public UEditorUtilityWidget CreatedUMGWidget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CreatedUMGWidget, __ReturnBuffer);

					return *(UEditorUtilityWidget*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CreatedUMGWidget, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityWidgetBlueprint");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bIsEnabledInPIE = 0;

		private static uint __bIsEnabledInDebugging = 0;

		private static uint __CreatedUMGWidget = 0;
	}
}