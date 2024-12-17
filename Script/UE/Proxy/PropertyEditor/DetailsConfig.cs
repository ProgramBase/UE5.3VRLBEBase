using Script.CoreUObject;
using Script.EditorConfig;
using Script.Library;

namespace Script.PropertyEditor
{
	[PathName("/Script/PropertyEditor.DetailsConfig")]
	public partial class UDetailsConfig : UEditorConfigBase, IStaticClass
	{
		public TMap<FName, FDetailsViewConfig> Views
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Views, __ReturnBuffer);

					return *(TMap<FName, FDetailsViewConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Views, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PropertyEditor.DetailsConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Views = 0;
	}
}