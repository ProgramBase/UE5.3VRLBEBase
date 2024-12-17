using Script.CoreUObject;
using Script.Library;

namespace Script.JsonUtilities
{
	[PathName("/Script/JsonUtilities.JsonUtilitiesDummyObject")]
	public partial class UJsonUtilitiesDummyObject : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/JsonUtilities.JsonUtilitiesDummyObject");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}