using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimBlueprintExtension_SharedLinkedAnimLayers")]
	public partial class UAnimBlueprintExtension_SharedLinkedAnimLayers : UAnimBlueprintExtension, IStaticClass
	{
		public FAnimSubsystem_SharedLinkedAnimLayers Subsystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Subsystem, __ReturnBuffer);

					return *(FAnimSubsystem_SharedLinkedAnimLayers*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Subsystem, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimBlueprintExtension_SharedLinkedAnimLayers");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Subsystem = 0;
	}
}