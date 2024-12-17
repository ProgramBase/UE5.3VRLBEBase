using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TestSparseClassDataBase")]
	public partial class UTestSparseClassDataBase : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TestSparseClassDataBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}