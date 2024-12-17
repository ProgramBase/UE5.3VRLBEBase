using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.ClassVariableCreator")]
	public partial class UClassVariableCreator : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.ClassVariableCreator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/AnimGraph.ClassVariableCreator")]
	public interface IClassVariableCreator : IInterface
	{
	}
}