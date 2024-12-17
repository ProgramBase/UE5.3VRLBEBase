using Script.CoreUObject;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.WidgetCompilerRule")]
	public partial class UWidgetCompilerRule : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.WidgetCompilerRule");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}