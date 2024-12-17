using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MaterialGraphNode_Composite")]
	public partial class UMaterialGraphNode_Composite : UMaterialGraphNode, IStaticClass
	{
		public UMaterialGraph BoundGraph
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoundGraph, __ReturnBuffer);

					return *(UMaterialGraph*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoundGraph, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MaterialGraphNode_Composite");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BoundGraph = 0;
	}
}