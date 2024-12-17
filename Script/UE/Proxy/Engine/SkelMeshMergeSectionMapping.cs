using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkelMeshMergeSectionMapping")]
	public partial class FSkelMeshMergeSectionMapping : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SkelMeshMergeSectionMapping");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSkelMeshMergeSectionMapping() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSkelMeshMergeSectionMapping() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSkelMeshMergeSectionMapping A, FSkelMeshMergeSectionMapping B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSkelMeshMergeSectionMapping A, FSkelMeshMergeSectionMapping B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSkelMeshMergeSectionMapping;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<int> SectionIDs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SectionIDs, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SectionIDs, __InBuffer);
				}
			}
		}

		private static uint __SectionIDs = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}