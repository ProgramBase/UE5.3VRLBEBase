using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AlembicLibrary
{
	[PathName("/Script/AlembicLibrary.AlembicTestCommandlet")]
	public partial class UAlembicTestCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AlembicLibrary.AlembicTestCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}