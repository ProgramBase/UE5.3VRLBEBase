using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialFunctionEditorOnlyData")]
	public partial class UMaterialFunctionEditorOnlyData : UMaterialFunctionInterfaceEditorOnlyData, IStaticClass
	{
		public FMaterialExpressionCollection ExpressionCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExpressionCollection, __ReturnBuffer);

					return *(FMaterialExpressionCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExpressionCollection, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialFunctionEditorOnlyData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ExpressionCollection = 0;
	}
}