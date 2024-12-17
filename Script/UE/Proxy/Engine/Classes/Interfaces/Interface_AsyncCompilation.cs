using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Interface_AsyncCompilation")]
	public partial class UInterface_AsyncCompilation : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Interface_AsyncCompilation");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.Interface_AsyncCompilation")]
	public interface IInterface_AsyncCompilation : IInterface
	{
	}
}