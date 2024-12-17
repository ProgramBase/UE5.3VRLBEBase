using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.UnrealEdKeyBindings")]
	public partial class UUnrealEdKeyBindings : UObject, IStaticClass
	{
		public TArray<FEditorKeyBinding> KeyBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __KeyBindings, __ReturnBuffer);

					return *(TArray<FEditorKeyBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __KeyBindings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.UnrealEdKeyBindings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __KeyBindings = 0;
	}
}