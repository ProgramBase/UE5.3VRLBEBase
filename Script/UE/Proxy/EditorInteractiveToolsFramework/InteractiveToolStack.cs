using Script.CoreUObject;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.InteractiveToolStack")]
	public partial class FInteractiveToolStack : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorInteractiveToolsFramework.InteractiveToolStack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInteractiveToolStack() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInteractiveToolStack() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInteractiveToolStack A, FInteractiveToolStack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInteractiveToolStack A, FInteractiveToolStack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInteractiveToolStack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}