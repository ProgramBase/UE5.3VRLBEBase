using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.LatticeDeformerOperatorFactory")]
	public partial class ULatticeDeformerOperatorFactory : UObject, IStaticClass
	{
		public ULatticeDeformerTool LatticeDeformerTool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LatticeDeformerTool, __ReturnBuffer);

					return *(ULatticeDeformerTool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LatticeDeformerTool, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.LatticeDeformerOperatorFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LatticeDeformerTool = 0;
	}
}