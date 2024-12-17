using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_MakeStruct")]
	public partial class UK2Node_MakeStruct : UK2Node_StructMemberSet, IStaticClass
	{
		public bool bMadeAfterOverridePinRemoval
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bMadeAfterOverridePinRemoval, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bMadeAfterOverridePinRemoval, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_MakeStruct");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bMadeAfterOverridePinRemoval = 0;
	}
}