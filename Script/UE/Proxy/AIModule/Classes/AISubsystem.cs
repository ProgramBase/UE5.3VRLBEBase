using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISubsystem")]
	public partial class UAISubsystem : UObject, IStaticClass
	{
		public UAISystem AISystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AISystem, __ReturnBuffer);

					return *(UAISystem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AISystem, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AISubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AISystem = 0;
	}
}