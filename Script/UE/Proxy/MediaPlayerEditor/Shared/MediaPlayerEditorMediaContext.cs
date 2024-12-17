using Script.CoreUObject;
using Script.ToolMenus;
using Script.Library;

namespace Script.MediaPlayerEditor
{
	[PathName("/Script/MediaPlayerEditor.MediaPlayerEditorMediaContext")]
	public partial class UMediaPlayerEditorMediaContext : UToolMenuContextBase, IStaticClass
	{
		public UObject SelectedAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedAsset, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedAsset, __InBuffer);
				}
			}
		}

		public FName StyleSetName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StyleSetName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StyleSetName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaPlayerEditor.MediaPlayerEditorMediaContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SelectedAsset = 0;

		private static uint __StyleSetName = 0;
	}
}