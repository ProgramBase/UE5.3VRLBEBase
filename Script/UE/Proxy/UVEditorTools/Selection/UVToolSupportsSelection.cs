using Script.CoreUObject;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVToolSupportsSelection")]
	public partial class UUVToolSupportsSelection : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVToolSupportsSelection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/UVEditorTools.UVToolSupportsSelection")]
	public interface IUVToolSupportsSelection : IInterface
	{
	}
}