using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.NetBlobHandlerDefinitions")]
	public partial class UNetBlobHandlerDefinitions : UObject, IStaticClass
	{
		public TArray<FNetBlobHandlerDefinition> NetBlobHandlerDefinitions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NetBlobHandlerDefinitions, __ReturnBuffer);

					return *(TArray<FNetBlobHandlerDefinition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NetBlobHandlerDefinitions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.NetBlobHandlerDefinitions");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NetBlobHandlerDefinitions = 0;
	}
}