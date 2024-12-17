using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithMeshSectionInfoTemplate")]
	public partial class FDatasmithMeshSectionInfoTemplate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DatasmithContent.DatasmithMeshSectionInfoTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDatasmithMeshSectionInfoTemplate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDatasmithMeshSectionInfoTemplate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDatasmithMeshSectionInfoTemplate A, FDatasmithMeshSectionInfoTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDatasmithMeshSectionInfoTemplate A, FDatasmithMeshSectionInfoTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDatasmithMeshSectionInfoTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int MaterialIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaterialIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaterialIndex, __InBuffer);
				}
			}
		}

		private static uint __MaterialIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}