using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetObjectPrioritizerDefinitions")]
	public partial class UNetObjectPrioritizerDefinitions : UObject, IStaticClass
	{
		public TArray<FNetObjectPrioritizerDefinition> NetObjectPrioritizerDefinitions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetObjectPrioritizerDefinitions, __ReturnBuffer);

					return *(TArray<FNetObjectPrioritizerDefinition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetObjectPrioritizerDefinitions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetObjectPrioritizerDefinitions");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NetObjectPrioritizerDefinitions = 0;
	}
}