using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CameraShakeSourceActor")]
	public partial class ACameraShakeSourceActor : AActor, IStaticClass
	{
		public UCameraShakeSourceComponent CameraShakeSourceComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CameraShakeSourceComponent, __ReturnBuffer);

					return *(UCameraShakeSourceComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CameraShakeSourceComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CameraShakeSourceActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CameraShakeSourceComponent = 0;
	}
}