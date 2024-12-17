using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.DataStreamDefinitions")]
	public partial class UDataStreamDefinitions : UObject, IStaticClass
	{
		public TArray<FDataStreamDefinition> DataStreamDefinitions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataStreamDefinitions, __ReturnBuffer);

					return *(TArray<FDataStreamDefinition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataStreamDefinitions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.DataStreamDefinitions");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DataStreamDefinitions = 0;
	}
}