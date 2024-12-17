using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ReporterGraph")]
	public partial class UReporterGraph : UReporterBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ReporterGraph");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}