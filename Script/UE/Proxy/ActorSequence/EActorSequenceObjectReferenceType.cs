using Script.CoreUObject;

namespace Script.ActorSequence
{
	[PathName("/Script/ActorSequence.EActorSequenceObjectReferenceType")]
	public enum EActorSequenceObjectReferenceType : byte
	{
		ContextActor = 0,
		ExternalActor = 1,
		Component = 2,
	}
}