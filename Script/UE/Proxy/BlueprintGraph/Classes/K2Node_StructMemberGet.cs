using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_StructMemberGet")]
	public partial class UK2Node_StructMemberGet : UK2Node_StructOperation, IStaticClass
	{
		public TArray<FOptionalPinFromProperty> ShowPinForProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShowPinForProperties, __ReturnBuffer);

					return *(TArray<FOptionalPinFromProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShowPinForProperties, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_StructMemberGet");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ShowPinForProperties = 0;
	}
}