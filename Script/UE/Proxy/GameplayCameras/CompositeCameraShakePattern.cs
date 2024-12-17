using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GameplayCameras
{
	[PathName("/Script/GameplayCameras.CompositeCameraShakePattern")]
	public partial class UCompositeCameraShakePattern : UCameraShakePattern, IStaticClass
	{
		public TArray<UCameraShakePattern> ChildPatterns
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChildPatterns, __ReturnBuffer);

					return *(TArray<UCameraShakePattern>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChildPatterns, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayCameras.CompositeCameraShakePattern");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ChildPatterns = 0;
	}
}