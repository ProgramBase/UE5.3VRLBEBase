using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_MacroInstance")]
	public partial class UK2Node_MacroInstance : UK2Node_Tunnel, IStaticClass
	{
		public FGraphReference MacroGraphReference
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MacroGraphReference, __ReturnBuffer);

					return *(FGraphReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MacroGraphReference, __InBuffer);
				}
			}
		}

		public FEdGraphPinType ResolvedWildcardType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ResolvedWildcardType, __ReturnBuffer);

					return *(FEdGraphPinType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ResolvedWildcardType, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_MacroInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MacroGraphReference = 0;

		private static uint __ResolvedWildcardType = 0;
	}
}