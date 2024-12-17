using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActorFolderSet")]
	public partial class FActorFolderSet : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ActorFolderSet");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorFolderSet() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActorFolderSet() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActorFolderSet A, FActorFolderSet B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorFolderSet A, FActorFolderSet B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorFolderSet;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSet<UActorFolder> ActorFolders
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorFolders, __ReturnBuffer);

					return *(TSet<UActorFolder>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorFolders, __InBuffer);
				}
			}
		}

		private static uint __ActorFolders = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}