using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleAccelerationDragScaleOverLife")]
	public partial class UParticleModuleAccelerationDragScaleOverLife : UParticleModuleAccelerationBase, IStaticClass
	{
		public FRawDistributionFloat DragScaleRaw
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DragScaleRaw, __ReturnBuffer);

					return *(FRawDistributionFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DragScaleRaw, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleAccelerationDragScaleOverLife");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DragScaleRaw = 0;
	}
}