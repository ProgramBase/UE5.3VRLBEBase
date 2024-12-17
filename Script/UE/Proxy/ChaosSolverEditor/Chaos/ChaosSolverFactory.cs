using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.ChaosSolverEditor
{
	[PathName("/Script/ChaosSolverEditor.ChaosSolverFactory")]
	public partial class UChaosSolverFactory : UFactory, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosSolverEditor.ChaosSolverFactory");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}