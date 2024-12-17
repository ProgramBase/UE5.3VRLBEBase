using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Interface_PreviewMeshProvider")]
	public partial class UInterface_PreviewMeshProvider : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Interface_PreviewMeshProvider");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.Interface_PreviewMeshProvider")]
	public interface IInterface_PreviewMeshProvider : IInterface
	{
	}
}