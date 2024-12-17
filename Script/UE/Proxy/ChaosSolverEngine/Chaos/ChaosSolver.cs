using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.ChaosSolver")]
	public partial class UChaosSolver : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosSolverEngine.ChaosSolver");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}