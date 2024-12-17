using Script.CoreUObject;
using Script.Library;

namespace Script.EditorFramework
{
	[PathName("/Script/EditorFramework.TypedElementDetailsInterface")]
	public partial class UTypedElementDetailsInterface : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorFramework.TypedElementDetailsInterface");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/EditorFramework.TypedElementDetailsInterface")]
	public interface ITypedElementDetailsInterface : IInterface
	{
	}
}