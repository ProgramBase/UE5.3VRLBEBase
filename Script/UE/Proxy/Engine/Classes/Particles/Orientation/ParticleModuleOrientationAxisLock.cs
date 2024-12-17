using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleOrientationAxisLock")]
	public partial class UParticleModuleOrientationAxisLock : UParticleModuleOrientationBase, IStaticClass
	{
		public EParticleAxisLock LockAxisFlags
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LockAxisFlags, __ReturnBuffer);

					return *(EParticleAxisLock*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LockAxisFlags, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleOrientationAxisLock");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LockAxisFlags = 0;
	}
}