using Script.CoreUObject;

namespace Script.MetasoundFrontend
{
	[PathName("/Script/MetasoundFrontend.EMetasoundFrontendClassType")]
	public enum EMetasoundFrontendClassType : byte
	{
		External = 0,
		Graph = 1,
		Input = 2,
		Output = 3,
		Literal = 4,
		Variable = 5,
		VariableDeferredAccessor = 6,
		VariableAccessor = 7,
		VariableMutator = 8,
		Template = 9,
		Invalid = 10,
	}
}