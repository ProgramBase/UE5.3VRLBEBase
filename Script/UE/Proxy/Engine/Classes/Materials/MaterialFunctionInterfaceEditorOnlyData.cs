using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialFunctionInterfaceEditorOnlyData")]
	public partial class UMaterialFunctionInterfaceEditorOnlyData : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialFunctionInterfaceEditorOnlyData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}