using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.BlueprintNodeSpawner")]
	public partial class UBlueprintNodeSpawner : UObject, IStaticClass
	{
		public TSubclassOf<UEdGraphNode> NodeClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NodeClass, __ReturnBuffer);

					return *(TSubclassOf<UEdGraphNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NodeClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.BlueprintNodeSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NodeClass = 0;
	}
}