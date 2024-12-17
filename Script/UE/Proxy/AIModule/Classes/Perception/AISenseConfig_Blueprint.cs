using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AISenseConfig_Blueprint")]
	public partial class UAISenseConfig_Blueprint : UAISenseConfig, IStaticClass
	{
		public TSubclassOf<UAISense_Blueprint> Implementation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Implementation, __ReturnBuffer);

					return *(TSubclassOf<UAISense_Blueprint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Implementation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AISenseConfig_Blueprint");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Implementation = 0;
	}
}