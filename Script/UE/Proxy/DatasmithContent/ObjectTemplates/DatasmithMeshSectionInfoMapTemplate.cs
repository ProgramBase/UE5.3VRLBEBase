using Script.CoreUObject;
using Script.Library;

namespace Script.DatasmithContent
{
	[PathName("/Script/DatasmithContent.DatasmithMeshSectionInfoMapTemplate")]
	public partial class FDatasmithMeshSectionInfoMapTemplate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DatasmithContent.DatasmithMeshSectionInfoMapTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDatasmithMeshSectionInfoMapTemplate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDatasmithMeshSectionInfoMapTemplate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDatasmithMeshSectionInfoMapTemplate A, FDatasmithMeshSectionInfoMapTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDatasmithMeshSectionInfoMapTemplate A, FDatasmithMeshSectionInfoMapTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDatasmithMeshSectionInfoMapTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<uint, FDatasmithMeshSectionInfoTemplate> Map
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Map, __ReturnBuffer);

					return *(TMap<uint, FDatasmithMeshSectionInfoTemplate>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Map, __InBuffer);
				}
			}
		}

		private static uint __Map = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}