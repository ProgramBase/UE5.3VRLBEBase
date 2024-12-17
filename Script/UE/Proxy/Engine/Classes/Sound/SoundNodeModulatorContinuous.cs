using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SoundNodeModulatorContinuous")]
	public partial class USoundNodeModulatorContinuous : USoundNode, IStaticClass
	{
		public FModulatorContinuousParams PitchModulationParams
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PitchModulationParams, __ReturnBuffer);

					return *(FModulatorContinuousParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PitchModulationParams, __InBuffer);
				}
			}
		}

		public FModulatorContinuousParams VolumeModulationParams
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VolumeModulationParams, __ReturnBuffer);

					return *(FModulatorContinuousParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VolumeModulationParams, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SoundNodeModulatorContinuous");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PitchModulationParams = 0;

		private static uint __VolumeModulationParams = 0;
	}
}