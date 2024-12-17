using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeEngine
{
	[PathName("/Script/InterchangeEngine.InterchangeMeshUtilities")]
	public partial class UInterchangeMeshUtilities : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeEngine.InterchangeMeshUtilities");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}