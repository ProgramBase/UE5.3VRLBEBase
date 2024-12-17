using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.BlueprintVariableNodeSpawner")]
	public partial class UBlueprintVariableNodeSpawner : UBlueprintFieldNodeSpawner, IStaticClass
	{
		public UEdGraph LocalVarOuter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LocalVarOuter, __ReturnBuffer);

					return *(UEdGraph*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LocalVarOuter, __InBuffer);
				}
			}
		}

		public FBPVariableDescription LocalVarDesc
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LocalVarDesc, __ReturnBuffer);

					return *(FBPVariableDescription*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LocalVarDesc, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.BlueprintVariableNodeSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LocalVarOuter = 0;

		private static uint __LocalVarDesc = 0;
	}
}