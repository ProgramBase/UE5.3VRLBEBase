using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BoxReflectionCaptureComponent")]
	public partial class UBoxReflectionCaptureComponent : UReflectionCaptureComponent, IStaticClass
	{
		public float BoxTransitionDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoxTransitionDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoxTransitionDistance, __InBuffer);
				}
			}
		}

		public UBoxComponent PreviewInfluenceBox
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewInfluenceBox, __ReturnBuffer);

					return *(UBoxComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewInfluenceBox, __InBuffer);
				}
			}
		}

		public UBoxComponent PreviewCaptureBox
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewCaptureBox, __ReturnBuffer);

					return *(UBoxComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewCaptureBox, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BoxReflectionCaptureComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BoxTransitionDistance = 0;

		private static uint __PreviewInfluenceBox = 0;

		private static uint __PreviewCaptureBox = 0;
	}
}