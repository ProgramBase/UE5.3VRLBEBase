using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorBaseUserWidget")]
	public partial class UVREditorBaseUserWidget : UUserWidget, IStaticClass
	{
		public TWeakObjectPtr<AVREditorFloatingUI> Owner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Owner, __ReturnBuffer);

					return *(TWeakObjectPtr<AVREditorFloatingUI>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Owner, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VREditorBaseUserWidget");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Owner = 0;
	}
}