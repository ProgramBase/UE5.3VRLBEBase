using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialFunctionMaterialLayer")]
	public partial class UMaterialFunctionMaterialLayer : UMaterialFunction, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialFunctionMaterialLayer");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}