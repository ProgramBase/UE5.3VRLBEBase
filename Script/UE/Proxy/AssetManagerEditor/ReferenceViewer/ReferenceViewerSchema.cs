using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AssetManagerEditor
{
	[PathName("/Script/AssetManagerEditor.ReferenceViewerSchema")]
	public partial class UReferenceViewerSchema : UEdGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetManagerEditor.ReferenceViewerSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}