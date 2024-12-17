using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimBlueprintExtension_BlendSpaceGraph")]
	public partial class UAnimBlueprintExtension_BlendSpaceGraph : UAnimBlueprintExtension, IStaticClass
	{
		public TSubclassOf<UObject> Class
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Class, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Class, __InBuffer);
				}
			}
		}

		public FAnimSubsystem_BlendSpaceGraph Subsystem
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Subsystem, __ReturnBuffer);

					return *(FAnimSubsystem_BlendSpaceGraph*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimBlueprintExtension_BlendSpaceGraph");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Class = 0;

		private static uint __Subsystem = 0;
	}
}