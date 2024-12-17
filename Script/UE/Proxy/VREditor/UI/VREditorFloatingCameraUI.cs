using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorFloatingCameraUI")]
	public partial class AVREditorFloatingCameraUI : AVREditorFloatingUI, IStaticClass
	{
		public FVector OffsetFromCamera
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OffsetFromCamera, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OffsetFromCamera, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<AActor> LinkedActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LinkedActor, __ReturnBuffer);

					return *(TWeakObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LinkedActor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VREditorFloatingCameraUI");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OffsetFromCamera = 0;

		private static uint __LinkedActor = 0;
	}
}