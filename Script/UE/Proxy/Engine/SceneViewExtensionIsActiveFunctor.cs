using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SceneViewExtensionIsActiveFunctor")]
	public partial class FSceneViewExtensionIsActiveFunctor : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SceneViewExtensionIsActiveFunctor");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSceneViewExtensionIsActiveFunctor() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSceneViewExtensionIsActiveFunctor() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSceneViewExtensionIsActiveFunctor A, FSceneViewExtensionIsActiveFunctor B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSceneViewExtensionIsActiveFunctor A, FSceneViewExtensionIsActiveFunctor B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSceneViewExtensionIsActiveFunctor;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}