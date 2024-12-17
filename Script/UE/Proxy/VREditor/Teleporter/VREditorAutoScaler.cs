using Script.CoreUObject;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorAutoScaler")]
	public partial class UVREditorAutoScaler : UObject, IStaticClass
	{
		public UVREditorMode VRMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VRMode, __ReturnBuffer);

					return *(UVREditorMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VRMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VREditorAutoScaler");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __VRMode = 0;
	}
}