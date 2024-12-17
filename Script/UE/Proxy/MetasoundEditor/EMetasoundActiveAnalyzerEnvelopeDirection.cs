using Script.CoreUObject;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.EMetasoundActiveAnalyzerEnvelopeDirection")]
	public enum EMetasoundActiveAnalyzerEnvelopeDirection : byte
	{
		FromSourceOutput = 0,
		FromDestinationInput = 1,
	}
}