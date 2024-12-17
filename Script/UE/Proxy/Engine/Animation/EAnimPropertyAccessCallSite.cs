using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAnimPropertyAccessCallSite")]
	public enum EAnimPropertyAccessCallSite : long
	{
		WorkerThread_Unbatched = 0,
		WorkerThread_Batched_PreEventGraph = 1,
		WorkerThread_Batched_PostEventGraph = 2,
		GameThread_Batched_PreEventGraph = 3,
		GameThread_Batched_PostEventGraph = 4,
	}
}