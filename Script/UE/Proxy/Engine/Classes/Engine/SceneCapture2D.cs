using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SceneCapture2D")]
	public partial class ASceneCapture2D : ASceneCapture, IStaticClass
	{
		public USceneCaptureComponent2D CaptureComponent2D
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureComponent2D, __ReturnBuffer);

					return *(USceneCaptureComponent2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CaptureComponent2D, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SceneCapture2D");
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

		private static uint __CaptureComponent2D = 0;

		private static uint __OnInterpToggle = 0;
	}
}