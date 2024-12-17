using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SceneCaptureCube")]
	public partial class ASceneCaptureCube : ASceneCapture, IStaticClass
	{
		public USceneCaptureComponentCube CaptureComponentCube
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureComponentCube, __ReturnBuffer);

					return *(USceneCaptureComponentCube*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureComponentCube, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SceneCaptureCube");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void OnInterpToggle(bool bEnable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnInterpToggle, __InBuffer);
			}
		}

		private static uint __CaptureComponentCube = 0;

		private static uint __OnInterpToggle = 0;
	}
}