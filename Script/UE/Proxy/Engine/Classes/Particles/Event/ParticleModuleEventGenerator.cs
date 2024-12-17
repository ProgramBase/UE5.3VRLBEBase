using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ParticleModuleEventGenerator")]
	public partial class UParticleModuleEventGenerator : UParticleModuleEventBase, IStaticClass
	{
		public TArray<FParticleEvent_GenerateInfo> Events
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Events, __ReturnBuffer);

					return *(TArray<FParticleEvent_GenerateInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Events, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ParticleModuleEventGenerator");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Events = 0;
	}
}