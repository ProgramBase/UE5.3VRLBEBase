using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.PatchId")]
	public partial class FPatchId : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.PatchId");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPatchId() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPatchId() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPatchId A, FPatchId B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPatchId A, FPatchId B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPatchId;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Id
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Id, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Id, __InBuffer);
				}
			}
		}

		private static uint __Id = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}