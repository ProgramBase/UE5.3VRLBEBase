using Script.CoreUObject;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityExtension")]
	public partial class UEditorUtilityExtension : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityExtension");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Blutility.EditorUtilityExtension")]
	public interface IEditorUtilityExtension : IInterface
	{
	}
}