using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PreviewCollectionInterface")]
	public partial class UPreviewCollectionInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PreviewCollectionInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.PreviewCollectionInterface")]
	public interface IPreviewCollectionInterface : IInterface
	{
	}
}