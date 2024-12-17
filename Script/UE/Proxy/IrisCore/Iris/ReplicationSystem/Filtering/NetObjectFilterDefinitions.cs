using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetObjectFilterDefinitions")]
	public partial class UNetObjectFilterDefinitions : UObject, IStaticClass
	{
		public TArray<FNetObjectFilterDefinition> NetObjectFilterDefinitions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetObjectFilterDefinitions, __ReturnBuffer);

					return *(TArray<FNetObjectFilterDefinition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetObjectFilterDefinitions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetObjectFilterDefinitions");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NetObjectFilterDefinitions = 0;
	}
}