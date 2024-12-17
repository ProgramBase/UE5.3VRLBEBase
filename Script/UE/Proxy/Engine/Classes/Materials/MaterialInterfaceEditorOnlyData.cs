using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MaterialInterfaceEditorOnlyData")]
	public partial class UMaterialInterfaceEditorOnlyData : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MaterialInterfaceEditorOnlyData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}