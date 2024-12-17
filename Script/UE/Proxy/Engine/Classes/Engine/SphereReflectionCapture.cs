using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SphereReflectionCapture")]
	public partial class ASphereReflectionCapture : AReflectionCapture, IStaticClass
	{
		public UDrawSphereComponent DrawCaptureRadius
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DrawCaptureRadius, __ReturnBuffer);

					return *(UDrawSphereComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DrawCaptureRadius, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SphereReflectionCapture");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DrawCaptureRadius = 0;
	}
}