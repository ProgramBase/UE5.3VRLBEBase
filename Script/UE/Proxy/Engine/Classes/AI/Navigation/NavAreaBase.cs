using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.NavAreaBase")]
	public partial class UNavAreaBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.NavAreaBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}