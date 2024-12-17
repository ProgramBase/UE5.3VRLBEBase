using Script.CoreUObject;
using Script.TypedElementRuntime;
using Script.Library;

namespace Script.LevelEditor
{
	[PathName("/Script/LevelEditor.QuickActionMenuContext")]
	public partial class UQuickActionMenuContext : UObject, IStaticClass
	{
		public UTypedElementSelectionSet CurrentSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentSelection, __ReturnBuffer);

					return *(UTypedElementSelectionSet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentSelection, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelEditor.QuickActionMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CurrentSelection = 0;
	}
}