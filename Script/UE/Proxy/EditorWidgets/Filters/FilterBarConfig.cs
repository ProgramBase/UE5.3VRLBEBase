using Script.CoreUObject;
using Script.EditorConfig;
using Script.Library;

namespace Script.EditorWidgets
{
	[PathName("/Script/EditorWidgets.FilterBarConfig")]
	public partial class UFilterBarConfig : UEditorConfigBase, IStaticClass
	{
		public TMap<FName, FFilterBarSettings> FilterBars
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FilterBars, __ReturnBuffer);

					return *(TMap<FName, FFilterBarSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FilterBars, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorWidgets.FilterBarConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FilterBars = 0;
	}
}