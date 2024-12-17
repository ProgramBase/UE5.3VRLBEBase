using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SectionReference")]
	public partial class FSectionReference : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SectionReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSectionReference() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSectionReference() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSectionReference A, FSectionReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSectionReference A, FSectionReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSectionReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int SectionIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SectionIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SectionIndex, __InBuffer);
				}
			}
		}

		private static uint __SectionIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}