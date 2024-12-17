using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.TestSparseClassData")]
	public partial class UTestSparseClassData : UTestSparseClassDataBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.TestSparseClassData");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}