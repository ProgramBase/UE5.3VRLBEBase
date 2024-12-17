using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RuntimeOptionsBase")]
	public partial class URuntimeOptionsBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RuntimeOptionsBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}