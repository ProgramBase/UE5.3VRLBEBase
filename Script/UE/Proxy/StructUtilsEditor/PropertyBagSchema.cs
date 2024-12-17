using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.StructUtilsEditor
{
	[PathName("/Script/StructUtilsEditor.PropertyBagSchema")]
	public partial class UPropertyBagSchema : UEdGraphSchema_K2, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StructUtilsEditor.PropertyBagSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}