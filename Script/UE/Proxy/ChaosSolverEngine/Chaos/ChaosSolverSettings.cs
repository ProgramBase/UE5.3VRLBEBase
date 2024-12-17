using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.ChaosSolverSettings")]
	public partial class UChaosSolverSettings : UDeveloperSettings, IStaticClass
	{
		public FSoftClassPath DefaultChaosSolverActorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultChaosSolverActorClass, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultChaosSolverActorClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosSolverEngine.ChaosSolverSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DefaultChaosSolverActorClass = 0;
	}
}